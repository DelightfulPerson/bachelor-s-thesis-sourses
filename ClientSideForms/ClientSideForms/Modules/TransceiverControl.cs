using System;
using System.IO.Ports;
using System.Timers;
using System.Windows.Forms;

namespace ClientSideForms.Modules
{
    /// <summary>
    /// Клиент для сбора и передачи данных из МК на web-сервер
    /// </summary>
    public class TransceiverControl : IDisposable
    {
        private readonly SerialPort _port;

        private readonly ClientControl _clientForm;

        private readonly SocketTcpServer _socketTcp = new();

        private static System.Timers.Timer _myTimer;

        #region Зона определения переменных

        private static readonly int dataSoursesNumber = 2;

        private static int index = 0;

        private static bool _isSendDataToServer = false;

        private double[] _bufferToServer = new double[dataSoursesNumber];

        private double convertedSensVal;

        #endregion

        public TransceiverControl(string portName, int baudRate,
            int dataBits, StopBits stopBits, Parity parityBits, ClientControl mainForm)
        {
            _clientForm = mainForm;
            _port = new SerialPort(portName)
            {
                BaudRate = baudRate,
                DataBits = dataBits,
                StopBits = stopBits,
                Parity = parityBits
            };

            _port.DataReceived += PortOnDataReceived;
        }

        private void PortOnDataReceived(object sender, SerialDataReceivedEventArgs serialDataReceivedEventArgs)
        {
            if (!_port.IsOpen) return;

            try
            {
                int bytesCount = _port.BytesToRead;
                if (bytesCount <= 0) return;

                byte[] bytes = new byte[bytesCount];
                int readCount = _port.Read(bytes, 0, bytes.Length);

                if (readCount > 0)
                {
                    byte channelNum = (byte)(bytes[2] & 0x0F);

                    ushort adcVal = bytes[0];
                    adcVal = (ushort)(adcVal << 8);
                    adcVal += bytes[1];

                    if (channelNum is 1 or 2 or 3)
                    {
                        if (adcVal < 426)
                        {
                            convertedSensVal = -30;

                            ConvertSensValAndSendToServer(channelNum, adcVal, convertedSensVal);

                            _bufferToServer[index] = convertedSensVal;
                        }

                        if (adcVal >= 426 && adcVal < 2066)
                        {
                            convertedSensVal = (adcVal - 426) * 0.018292682926 - 30;

                            ConvertSensValAndSendToServer(channelNum, adcVal, convertedSensVal);

                            _bufferToServer[index] = convertedSensVal;
                        }

                        if (adcVal >= 2066 && adcVal <= 3706)
                        {
                            convertedSensVal = (adcVal - 2066) * 0.018292682926;

                            ConvertSensValAndSendToServer(channelNum, adcVal, convertedSensVal);

                            _bufferToServer[index] = convertedSensVal;
                        }

                        if (adcVal > 3706)
                        {
                            convertedSensVal = 30;

                            ConvertSensValAndSendToServer(channelNum, adcVal, convertedSensVal);

                            _bufferToServer[index] = convertedSensVal;
                        }

                        if (index == dataSoursesNumber - 1 && _isSendDataToServer)
                        {
                            SetTimer();
                            _socketTcp.SendDataToServer(_bufferToServer);
                            //Thread.Sleep(1000);
                        }

                        index = index < dataSoursesNumber - 1 ? index + 1 : 0;
                    }
                }
            }
            catch (TimeoutException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка приёма данных из приемопередатчика", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConvertSensValAndSendToServer(int channelNum, ushort adcVal, double convertedSensVal)
        {
            string dataTmp = $"\tДанные канала: {channelNum}" + Environment.NewLine +
                             $"Значение АЦП: {adcVal}" + Environment.NewLine +
                             $"Значение тока = {convertedSensVal} А" + Environment.NewLine;

            _clientForm.Invoke(new Action(() => _clientForm.ShowReceivedData(dataTmp)));


        }


        public TransceiverControl WriteByte(byte b)
        {
            if (!_port.IsOpen) return this;

            try
            {
                if (_port.IsOpen) _port.Write(new[] { b }, 0, 1);
            }
            catch (TimeoutException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка отправки данных в приемопередатчик", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return this;
        }

        public void CheckConnectionToServer()
        {
            _isSendDataToServer = _socketTcp.CheckConnectToServer();
        }

        public void ConnectToServer()
        {
            _socketTcp.ConnectByTcp();
        }

        public void WriteCommand(byte[] command)
        {
            if (!_port.IsOpen) return;

            try
            {
                _port.Write(command, 0, 2);
            }
            catch (TimeoutException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка отправки данных в приемопередатчик", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Open()
        {
            if (!_port.IsOpen) _port.Open();
        }

        public bool CheckStatus() => _port.IsOpen;

        public void Close()
        {
            if (_port.IsOpen) _port.Close();
        }

        public void Dispose()
        {
            _port.Dispose();
        }

        public void StartReceive()
        {
            WriteCommand(new byte[] { 0x55, 0x96 });
        }

        public void InterruptReceive()
        {
            WriteCommand(new byte[] { 0xAA, 0x96 });
        }

        private void SetTimer()
        {
            // Create a timer with a two second interval.
            _myTimer = new System.Timers.Timer(39500);
            // Hook up the Elapsed event for the timer. 
            _myTimer.Elapsed += OnTimedEvent;
            _myTimer.Enabled = true;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            _isSendDataToServer = false;
            _socketTcp.Disconnect();
        }
    }
}

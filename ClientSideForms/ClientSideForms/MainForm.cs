using ClientSideForms.Modules;
using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;


namespace ClientSideForms
{
    /// <summary>
    /// Графическое приложение для управления передачей данных
    /// </summary>
    public partial class ClientControl : Form
    {
        private TransceiverControl _port;

        private string _dataOut;

        private byte _byteString;
        
        public ClientControl()
        {
            InitializeComponent();
        }

        private void ClientControl_Load(object sender, EventArgs e)
        {
            string[] tranceiverPorts = SerialPort.GetPortNames();
            cBoxCOMPort.Items.AddRange(tranceiverPorts);
            cBoxIPAddress.Items.Add(LocalHost.GetLocalIPAddress());
            cBoxTcpPort.Items.Add(LocalHost._port);

            btnOpen.Enabled = true;
            btnClose.Enabled = false;
            lblConnectStatusToServer.Text = "Соединение\nустановлено";
            lblConnectStatusToServer.ForeColor = Color.MediumSeaGreen;
            btnTransmitData.Enabled = false;
            btnReceiveData.Enabled = false;
            btnStopReceiveData.Enabled = false;

            btnConnectToServer.Enabled = false;
            btnSendDataToServer.Enabled = false;

            //chBoxAlwaysUpdate.Checked = true;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                _port = new TransceiverControl(
                    cBoxCOMPort.Text,
                    Convert.ToInt32(cBoxBaudRate.Text),
                    Convert.ToInt32(cBoxDataBits.Text),
                    (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text),
                    (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text),
                    this);

                _port.Open();
                lblConectStatusToPort.Text = "Соединение\nустановлено";
                lblConectStatusToPort.ForeColor = Color.MediumSeaGreen;

                btnOpen.Enabled = false;
                btnClose.Enabled = true;

                btnTransmitData.Enabled = true;
                btnReceiveData.Enabled = true;
                btnStopReceiveData.Enabled = true;

                btnConnectToServer.Enabled = true;
                btnSendDataToServer.Enabled = true;

                cBoxCOMPort.Enabled = false;
                cBoxBaudRate.Enabled = false;
                cBoxDataBits.Enabled = false;
                cBoxStopBits.Enabled = false;
                cBoxParityBits.Enabled = false;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Не возможно открыть порт!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            _port.Close();
            _port.InterruptReceive();

            lblConectStatusToPort.Text = "Соединение\nотсутствует";
            lblConectStatusToPort.ForeColor = Color.Red;

            btnOpen.Enabled = true;
            btnClose.Enabled = false;

            btnTransmitData.Enabled = false;
            btnReceiveData.Enabled = false;
            btnStopReceiveData.Enabled = false;

            btnConnectToServer.Enabled = false;
            btnSendDataToServer.Enabled = false;

            cBoxCOMPort.Enabled = true;
            cBoxBaudRate.Enabled = true;
            cBoxDataBits.Enabled = true;
            cBoxStopBits.Enabled = true;
            cBoxParityBits.Enabled = true;
        }

        private void btnTransmitData_Click(object sender, EventArgs e)
        {
            if (!_port.CheckStatus()) return;
            _dataOut = tBoxDataOut.Text;
            try
            {
                if (_dataOut.Length != 0)
                {
                    _byteString = byte.Parse(_dataOut);
                    _port.WriteByte(_byteString);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message, "Ошибка ввода команды!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearDataOut_Click(object sender, EventArgs e)
        {
            if (tBoxDataOut.Text != "")
            {
                tBoxDataOut.Text = "";
            }
        }

        private void btnReceiveData_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_port.CheckStatus()) return;
                _port.StartReceive();

                tBoxDataOut.Text = "Команда\nна пердачу данных отправлена!" + Environment.NewLine;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message, "Ошибка начала передачи данных!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnStopReceiveData_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_port.CheckStatus()) return;
                _port.InterruptReceive();

                tBoxDataOut.Text = "Команда\nна перкращение передачи данных отправлена!" + Environment.NewLine;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message, "Ошибка! Не возможно остановить приём данных.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearDataIn_Click(object sender, EventArgs e)
        {
            if (tBoxDataIn.Text != "")
            {
                tBoxDataIn.Text = "";
            }
        }

        private void chBoxAlwaysUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxAlwaysUpdate.Checked)
            {
                chBoxAlwaysUpdate.Checked = true;
                chBoxAddToOldData.Checked = false;
            }
        }

        private void chBoxAddToOldData_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxAddToOldData.Checked)
            {
                chBoxAddToOldData.Checked = true;
                chBoxAlwaysUpdate.Checked = false;
            }
        }

        public void ShowReceivedData(string inputData)
        {
            tBoxDataIn.AppendText(inputData);
        }

        private void btnConnectToServer_Click(object sender, EventArgs e)
        {
            if (!_port.CheckStatus()) return;

            lblConnectStatusToServer.Text = "Соединение\nустановлено";
            lblConnectStatusToServer.ForeColor = Color.MediumSeaGreen;
            _port.ConnectToServer();
        }

        private void btnSendDataToServer_Click(object sender, EventArgs e)
        {
            if (!_port.CheckStatus()) return;

            _port.CheckConnectionToServer();
        }
    }
}

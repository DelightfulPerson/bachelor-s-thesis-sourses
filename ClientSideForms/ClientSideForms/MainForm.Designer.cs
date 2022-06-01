
namespace ClientSideForms
{
    partial class ClientControl
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientControl));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxParityBits = new System.Windows.Forms.ComboBox();
            this.cBoxDataBits = new System.Windows.Forms.ComboBox();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.cBoxCOMPort = new System.Windows.Forms.ComboBox();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxIPAddress = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnTransmitData = new System.Windows.Forms.Button();
            this.btnReceiveData = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblConectStatusToPort = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tBoxDataOut = new System.Windows.Forms.TextBox();
            this.btnClearDataOut = new System.Windows.Forms.Button();
            this.lblConnectStatusToServer = new System.Windows.Forms.Label();
            this.btnConnectToServer = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnStopReceiveData = new System.Windows.Forms.Button();
            this.chBoxAddToOldData = new System.Windows.Forms.CheckBox();
            this.chBoxAlwaysUpdate = new System.Windows.Forms.CheckBox();
            this.btnClearDataIn = new System.Windows.Forms.Button();
            this.tBoxDataIn = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnSendDataToServer = new System.Windows.Forms.Button();
            this.cBoxTcpPort = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxParityBits);
            this.groupBox1.Controls.Add(this.cBoxDataBits);
            this.groupBox1.Controls.Add(this.cBoxStopBits);
            this.groupBox1.Controls.Add(this.cBoxCOMPort);
            this.groupBox1.Controls.Add(this.cBoxBaudRate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры соединения COM-порта";
            // 
            // cBoxParityBits
            // 
            this.cBoxParityBits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBoxParityBits.FormattingEnabled = true;
            this.cBoxParityBits.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cBoxParityBits.Location = new System.Drawing.Point(186, 153);
            this.cBoxParityBits.Name = "cBoxParityBits";
            this.cBoxParityBits.Size = new System.Drawing.Size(121, 24);
            this.cBoxParityBits.TabIndex = 7;
            this.cBoxParityBits.Text = "None";
            // 
            // cBoxDataBits
            // 
            this.cBoxDataBits.Cursor = System.Windows.Forms.Cursors.Default;
            this.cBoxDataBits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBoxDataBits.FormattingEnabled = true;
            this.cBoxDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cBoxDataBits.Location = new System.Drawing.Point(186, 93);
            this.cBoxDataBits.Name = "cBoxDataBits";
            this.cBoxDataBits.Size = new System.Drawing.Size(121, 24);
            this.cBoxDataBits.TabIndex = 5;
            this.cBoxDataBits.Text = "8";
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.Cursor = System.Windows.Forms.Cursors.Default;
            this.cBoxStopBits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopBits.Location = new System.Drawing.Point(186, 123);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(121, 24);
            this.cBoxStopBits.TabIndex = 6;
            this.cBoxStopBits.Text = "One";
            // 
            // cBoxCOMPort
            // 
            this.cBoxCOMPort.Cursor = System.Windows.Forms.Cursors.Default;
            this.cBoxCOMPort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBoxCOMPort.FormattingEnabled = true;
            this.cBoxCOMPort.Location = new System.Drawing.Point(186, 33);
            this.cBoxCOMPort.MinimumSize = new System.Drawing.Size(121, 0);
            this.cBoxCOMPort.Name = "cBoxCOMPort";
            this.cBoxCOMPort.Size = new System.Drawing.Size(121, 24);
            this.cBoxCOMPort.TabIndex = 3;
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.Cursor = System.Windows.Forms.Cursors.Default;
            this.cBoxBaudRate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.Items.AddRange(new object[] {
            "1800",
            "2400",
            "4800",
            "9600",
            "19200",
            "28800",
            "34800",
            "57600",
            "76800",
            "115200"});
            this.cBoxBaudRate.Location = new System.Drawing.Point(186, 63);
            this.cBoxBaudRate.MinimumSize = new System.Drawing.Size(121, 0);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(121, 24);
            this.cBoxBaudRate.TabIndex = 4;
            this.cBoxBaudRate.Text = "115200";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Проверка чётности";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Количество стоп битов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Число\r\nинформационных битов";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "COM порт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Скорость передачи";
            // 
            // cBoxIPAddress
            // 
            this.cBoxIPAddress.Cursor = System.Windows.Forms.Cursors.Default;
            this.cBoxIPAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBoxIPAddress.FormattingEnabled = true;
            this.cBoxIPAddress.Location = new System.Drawing.Point(196, 29);
            this.cBoxIPAddress.MinimumSize = new System.Drawing.Size(121, 0);
            this.cBoxIPAddress.Name = "cBoxIPAddress";
            this.cBoxIPAddress.Size = new System.Drawing.Size(121, 24);
            this.cBoxIPAddress.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP-адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "PORT сети";
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM7";
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.Location = new System.Drawing.Point(15, 116);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(115, 45);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "Соединить";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightCoral;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(192, 116);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 45);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Разорвать";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnTransmitData
            // 
            this.btnTransmitData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransmitData.Location = new System.Drawing.Point(8, 93);
            this.btnTransmitData.Name = "btnTransmitData";
            this.btnTransmitData.Size = new System.Drawing.Size(115, 45);
            this.btnTransmitData.TabIndex = 10;
            this.btnTransmitData.Text = "Передать данные";
            this.btnTransmitData.UseVisualStyleBackColor = true;
            this.btnTransmitData.Click += new System.EventHandler(this.btnTransmitData_Click);
            // 
            // btnReceiveData
            // 
            this.btnReceiveData.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnReceiveData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReceiveData.Location = new System.Drawing.Point(6, 353);
            this.btnReceiveData.Name = "btnReceiveData";
            this.btnReceiveData.Size = new System.Drawing.Size(115, 45);
            this.btnReceiveData.TabIndex = 12;
            this.btnReceiveData.Text = "Начать приём";
            this.btnReceiveData.UseVisualStyleBackColor = false;
            this.btnReceiveData.Click += new System.EventHandler(this.btnReceiveData_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 232);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblConectStatusToPort);
            this.groupBox5.Location = new System.Drawing.Point(6, 9);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(306, 101);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Статус соединения с COM-портом";
            // 
            // lblConectStatusToPort
            // 
            this.lblConectStatusToPort.AutoSize = true;
            this.lblConectStatusToPort.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblConectStatusToPort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblConectStatusToPort.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConectStatusToPort.ForeColor = System.Drawing.Color.Red;
            this.lblConectStatusToPort.Location = new System.Drawing.Point(88, 37);
            this.lblConectStatusToPort.Name = "lblConectStatusToPort";
            this.lblConectStatusToPort.Size = new System.Drawing.Size(138, 50);
            this.lblConectStatusToPort.TabIndex = 14;
            this.lblConectStatusToPort.Text = "Соединение\r\nотсутствует";
            this.lblConectStatusToPort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tBoxDataOut);
            this.groupBox3.Controls.Add(this.btnClearDataOut);
            this.groupBox3.Controls.Add(this.btnTransmitData);
            this.groupBox3.Location = new System.Drawing.Point(747, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 147);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Управление передачей данных";
            // 
            // tBoxDataOut
            // 
            this.tBoxDataOut.AllowDrop = true;
            this.tBoxDataOut.Location = new System.Drawing.Point(7, 21);
            this.tBoxDataOut.Multiline = true;
            this.tBoxDataOut.Name = "tBoxDataOut";
            this.tBoxDataOut.Size = new System.Drawing.Size(367, 66);
            this.tBoxDataOut.TabIndex = 17;
            // 
            // btnClearDataOut
            // 
            this.btnClearDataOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearDataOut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClearDataOut.Location = new System.Drawing.Point(129, 93);
            this.btnClearDataOut.Name = "btnClearDataOut";
            this.btnClearDataOut.Size = new System.Drawing.Size(115, 45);
            this.btnClearDataOut.TabIndex = 11;
            this.btnClearDataOut.Text = "Очистить окно";
            this.btnClearDataOut.UseVisualStyleBackColor = true;
            this.btnClearDataOut.Click += new System.EventHandler(this.btnClearDataOut_Click);
            // 
            // lblConnectStatusToServer
            // 
            this.lblConnectStatusToServer.AutoSize = true;
            this.lblConnectStatusToServer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblConnectStatusToServer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblConnectStatusToServer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectStatusToServer.ForeColor = System.Drawing.Color.Red;
            this.lblConnectStatusToServer.Location = new System.Drawing.Point(108, 37);
            this.lblConnectStatusToServer.Name = "lblConnectStatusToServer";
            this.lblConnectStatusToServer.Size = new System.Drawing.Size(138, 50);
            this.lblConnectStatusToServer.TabIndex = 19;
            this.lblConnectStatusToServer.Text = "Соединение\r\nотсутствует";
            this.lblConnectStatusToServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConnectToServer
            // 
            this.btnConnectToServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnectToServer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConnectToServer.Location = new System.Drawing.Point(28, 205);
            this.btnConnectToServer.Name = "btnConnectToServer";
            this.btnConnectToServer.Size = new System.Drawing.Size(115, 45);
            this.btnConnectToServer.TabIndex = 18;
            this.btnConnectToServer.Text = "Соединить";
            this.btnConnectToServer.UseVisualStyleBackColor = true;
            this.btnConnectToServer.Click += new System.EventHandler(this.btnConnectToServer_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnStopReceiveData);
            this.groupBox4.Controls.Add(this.chBoxAddToOldData);
            this.groupBox4.Controls.Add(this.chBoxAlwaysUpdate);
            this.groupBox4.Controls.Add(this.btnClearDataIn);
            this.groupBox4.Controls.Add(this.tBoxDataIn);
            this.groupBox4.Controls.Add(this.btnReceiveData);
            this.groupBox4.Location = new System.Drawing.Point(354, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(369, 415);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Управление приёмом данных";
            // 
            // btnStopReceiveData
            // 
            this.btnStopReceiveData.BackColor = System.Drawing.Color.LightCoral;
            this.btnStopReceiveData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStopReceiveData.Location = new System.Drawing.Point(248, 353);
            this.btnStopReceiveData.Name = "btnStopReceiveData";
            this.btnStopReceiveData.Size = new System.Drawing.Size(115, 45);
            this.btnStopReceiveData.TabIndex = 13;
            this.btnStopReceiveData.Text = "Остановить приём";
            this.btnStopReceiveData.UseVisualStyleBackColor = false;
            this.btnStopReceiveData.Click += new System.EventHandler(this.btnStopReceiveData_Click);
            // 
            // chBoxAddToOldData
            // 
            this.chBoxAddToOldData.AutoSize = true;
            this.chBoxAddToOldData.Location = new System.Drawing.Point(6, 326);
            this.chBoxAddToOldData.Name = "chBoxAddToOldData";
            this.chBoxAddToOldData.Size = new System.Drawing.Size(219, 21);
            this.chBoxAddToOldData.TabIndex = 16;
            this.chBoxAddToOldData.Text = "Очищать окно ввода данных";
            this.chBoxAddToOldData.UseVisualStyleBackColor = true;
            this.chBoxAddToOldData.CheckedChanged += new System.EventHandler(this.chBoxAddToOldData_CheckedChanged);
            // 
            // chBoxAlwaysUpdate
            // 
            this.chBoxAlwaysUpdate.AutoSize = true;
            this.chBoxAlwaysUpdate.Location = new System.Drawing.Point(6, 299);
            this.chBoxAlwaysUpdate.Name = "chBoxAlwaysUpdate";
            this.chBoxAlwaysUpdate.Size = new System.Drawing.Size(191, 21);
            this.chBoxAlwaysUpdate.TabIndex = 15;
            this.chBoxAlwaysUpdate.Text = "Аккумулировать данные";
            this.chBoxAlwaysUpdate.UseVisualStyleBackColor = true;
            this.chBoxAlwaysUpdate.CheckedChanged += new System.EventHandler(this.chBoxAlwaysUpdate_CheckedChanged);
            // 
            // btnClearDataIn
            // 
            this.btnClearDataIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearDataIn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClearDataIn.Location = new System.Drawing.Point(127, 353);
            this.btnClearDataIn.Name = "btnClearDataIn";
            this.btnClearDataIn.Size = new System.Drawing.Size(115, 45);
            this.btnClearDataIn.TabIndex = 14;
            this.btnClearDataIn.Text = "Очистить окно";
            this.btnClearDataIn.UseVisualStyleBackColor = true;
            this.btnClearDataIn.Click += new System.EventHandler(this.btnClearDataIn_Click);
            // 
            // tBoxDataIn
            // 
            this.tBoxDataIn.AllowDrop = true;
            this.tBoxDataIn.Location = new System.Drawing.Point(6, 21);
            this.tBoxDataIn.Multiline = true;
            this.tBoxDataIn.Name = "tBoxDataIn";
            this.tBoxDataIn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBoxDataIn.Size = new System.Drawing.Size(357, 272);
            this.tBoxDataIn.TabIndex = 18;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnSendDataToServer);
            this.groupBox6.Controls.Add(this.cBoxTcpPort);
            this.groupBox6.Controls.Add(this.btnConnectToServer);
            this.groupBox6.Controls.Add(this.cBoxIPAddress);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(747, 169);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(355, 258);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Управление подключением к web-серверу";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblConnectStatusToServer);
            this.groupBox7.Location = new System.Drawing.Point(7, 94);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(342, 105);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Статус соединения с web-сервером";
            // 
            // btnSendDataToServer
            // 
            this.btnSendDataToServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendDataToServer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSendDataToServer.Location = new System.Drawing.Point(214, 205);
            this.btnSendDataToServer.Name = "btnSendDataToServer";
            this.btnSendDataToServer.Size = new System.Drawing.Size(115, 45);
            this.btnSendDataToServer.TabIndex = 21;
            this.btnSendDataToServer.Text = "Начать передачу";
            this.btnSendDataToServer.UseVisualStyleBackColor = true;
            this.btnSendDataToServer.Click += new System.EventHandler(this.btnSendDataToServer_Click);
            // 
            // cBoxTcpPort
            // 
            this.cBoxTcpPort.Cursor = System.Windows.Forms.Cursors.Default;
            this.cBoxTcpPort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBoxTcpPort.FormattingEnabled = true;
            this.cBoxTcpPort.Location = new System.Drawing.Point(196, 64);
            this.cBoxTcpPort.MinimumSize = new System.Drawing.Size(121, 0);
            this.cBoxTcpPort.Name = "cBoxTcpPort";
            this.cBoxTcpPort.Size = new System.Drawing.Size(121, 24);
            this.cBoxTcpPort.TabIndex = 9;
            // 
            // ClientControl
            // 
            this.AcceptButton = this.btnTransmitData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClearDataOut;
            this.ClientSize = new System.Drawing.Size(1158, 435);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientControl";
            this.Text = "Transceiver Control";
            this.Load += new System.EventHandler(this.ClientControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBoxParityBits;
        private System.Windows.Forms.ComboBox cBoxDataBits;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnTransmitData;
        private System.Windows.Forms.Button btnReceiveData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cBoxCOMPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClearDataOut;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tBoxDataIn;
        private System.Windows.Forms.TextBox tBoxDataOut;
        private System.Windows.Forms.Button btnClearDataIn;
        private System.Windows.Forms.CheckBox chBoxAddToOldData;
        private System.Windows.Forms.CheckBox chBoxAlwaysUpdate;
        private System.Windows.Forms.Label lblConectStatusToPort;
        private System.Windows.Forms.Button btnStopReceiveData;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnConnectToServer;
        private System.Windows.Forms.Label lblConnectStatusToServer;
        private System.Windows.Forms.ComboBox cBoxIPAddress;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnSendDataToServer;
        private System.Windows.Forms.ComboBox cBoxTcpPort;
    }
}


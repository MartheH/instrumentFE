using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using System.IO;

namespace FirstWindowsFormsApp
{
    public partial class FormMain : Form
    {
        // Constants
        string[] analogSignals = new string[] { "0-5VDC", "0-10VDC", "0-15VDC", "0-20VDC" };
        string[] digitalSignals = new string[] { "5VCD", "10VDC", "15VDC", "20VDC" };
        string[] fieldbusSignals = new string[] { "Modus 1", "Modus 2", "Modus 3" };
        string fileNameInstrumentList = "register.csv";
        
        //Variables
        double lrvValue = 0.0;
        double urvValue = 0.0;
        double spanValue = 0.0;
        double alarmLvalue = 0.0;
        double alamrHvalue = 0.0;
        int RegisterIndex = 0;
        int analogIndex = 0;
        int digitalIndex = 0;
        int fieldbusIndex = 0;
        int xTimeValue = 0;

        DateTime sessionStartTime;
        List<string> servers = new List<string>();
        List<Instrument> instrumentList = new List<Instrument>();
        static SerialPort serialPort;

        public FormMain()
        {
            serialPort = new SerialPort();
            serialPort.PortName = "COM3";
            serialPort.BaudRate = 5000;
            serialPort.Parity = Parity.None;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            serialPort.Handshake = Handshake.None;
            InitializeComponent();

            IPAddress[] addresslist = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in addresslist)
            {
                if (address.AddressFamily == AddressFamily.InterNetwork)
                {
                    servers.Add(address.ToString());
                }
            }
        }

    private void FormMain_Load(object sender, EventArgs e)
        {
            panelMonitor.Visible = false;
            panelConf.Visible = false;
            sessionStartTime = DateTime.Now;
            statusLabelSensorData.Text = "Ready";
            comboBoxSignalType.Text = "";
            textBoxRegister.Text = "";

            //Load instrument.csv file
            string instrumentLine = "";
            string[] instrumentLineParts;
            var inputFile = new StreamReader(fileNameInstrumentList);   
        } 
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRegisterNew_Click(object sender, EventArgs e)
        {
            if (comboBoxInstrumentName.Text.Length == 0)
            {
                MessageBox.Show("Missing instrument name!");
                comboBoxInstrumentName.Focus();
            }

            else if (!NewSensorName())
            {
                MessageBox.Show("This instrument already exist");
            }

            else if (!comboBoxInstrumentName.Items.Contains(comboBoxInstrumentName.Text))
            {
                comboBoxInstrumentName.Items.Add(comboBoxInstrumentName.Text);
            }


            if (comboBoxSignalType.Text == "Analog")
            {
                if (textBoxLRV.Text == "")
                {
                    MessageBox.Show("Missing LRV-range!");
                    textBoxLRV.Focus();
                }
                
                else if (textBoxURV.Text == "")
                {
                    MessageBox.Show("Missing URV-range");
                    textBoxURV.Focus();
                }

                else if (Convert.ToDouble(textBoxURV.Text) <= Convert.ToDouble(textBoxLRV.Text))
                {
                    MessageBox.Show("The URV-value can not be lower than LRV-value.");
                    textBoxURV.Focus();
                }

                else if (textBoxAlarmH.Text == "")
                {
                    MessageBox.Show("Missing value on alarm high");
                    textBoxURV.Focus();
                }

                else if (textBoxAlarmL.Text == "")
                {
                    MessageBox.Show("Missing value on alarm low");
                    textBoxURV.Focus();
                }

                else if (Convert.ToDouble(textBoxAlarmH.Text) <= Convert.ToDouble(textBoxAlarmL.Text))
                {
                    MessageBox.Show("The alarm high- value can not be lower than the alarm low- value.");
                    textBoxURV.Focus();
                }
            }

            AddTextInTextRegister();
        }

        public bool NewInstrument(string sensorName)
        {
            bool newInstrument = true;
            instrumentList.ForEach(delegate (Instrument instrument)
            {
                if (instrument.SensorName == sensorName)
                {
                    newInstrument = false;
                }
            });
            return newInstrument;
        }

        private void AddTextInTextRegister()
        {
            if (NewInstrument(comboBoxInstrumentName.Text))
            {
                if (comboBoxSignalType.Text == "Analog")
                {
                    Instrument instrument = new Instrument( dateTimePickerRegisterDate.Text,
                                                            comboBoxInstrumentName.Text,
                                                            maskedTextBoxSerialNumber.Text,
                                                            comboBoxSignalType.Text,
                                                            comboBoxMeasureType.Text,
                                                            comboBoxOptions.Text,
                                                            textBoxComment.Text,
                                                            Convert.ToDouble(textBoxLRV.Text),
                                                            Convert.ToDouble(textBoxURV.Text),
                                                            textBoxUnit.Text,
                                                            Convert.ToDouble(textBoxAlarmL.Text),
                                                            Convert.ToDouble(textBoxAlarmH.Text)                                                                                            //alamrHvalue
                                                            );

                    textBoxRegister.AppendText(instrument.ToString());
                    listBoxServers.Items.Add(instrument);
                }

                else
                {
                    Instrument instrument = new Instrument(dateTimePickerRegisterDate.Text,
                                                            comboBoxInstrumentName.Text,
                                                            maskedTextBoxSerialNumber.Text,
                                                            comboBoxSignalType.Text,
                                                            comboBoxMeasureType.Text,
                                                            comboBoxOptions.Text,
                                                            textBoxComment.Text
                                                            );

                    textBoxRegister.AppendText(instrument.ToString());
                    listBoxServers.Items.Add(instrument);
                }
            }
        }

        private bool NewSensorName()
        {
            bool newSensorName = true;
            //check if the instrument already is in the list
            instrumentList.ForEach(delegate (Instrument instrument)
            {
                if (instrument.SensorName == comboBoxInstrumentName.Text)
                {
                    MessageBox.Show("Instrument name exist", "Register Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    newSensorName = false;
                    comboBoxInstrumentName.Focus();
                }
            });
            return newSensorName;
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            AddTextInTextRegister();
        }

        // MouseHover
        private void comboBoxInstrumentName_MouseHover(object sender, EventArgs e)
        {
            statusLabelSensorData.Text = "Enter sensor name";
        }

        private void tabControl1_MouseHover(object sender, EventArgs e)
        {
            statusLabelSensorData.Text = "Ready";
        }

        private void maskedTextBoxSerialNumber_MouseHover(object sender, EventArgs e)
        {
            statusLabelSensorData.Text = "Enter serial number";
        }

        private void tabPage1_MouseHover(object sender, EventArgs e)
        {
            statusLabelSensorData.Text = "Ready";
        }

        private void checkBoxRegistered_MouseHover(object sender, EventArgs e)
        {
            statusLabelSensorData.Text = "Check out if registered";
        }

        private void dateTimePickerRegisterDate_MouseHover(object sender, EventArgs e)
        {
            statusLabelSensorData.Text = "Choose register date";
        }

        private void comboBoxSignalType_MouseHover(object sender, EventArgs e)
        {
            statusLabelSensorData.Text = "Choose signal type";
        }

        private void textBoxComment_MouseHover(object sender, EventArgs e)
        {
            statusLabelSensorData.Text = "Write comments";
        }

        private void comboBoxMeasureType_MouseHover(object sender, EventArgs e)
        {
            statusLabelSensorData.Text = "Choose measure type";
        }

        private void comboBoxOptions_MouseHover(object sender, EventArgs e)
        {
            statusLabelSensorData.Text = "Choose options";
        }

        private void textBoxLRV_MouseHover(object sender, EventArgs e)
        {
            statusLabelSensorData.Text = "Write LRV-value";
        }

        private void textBoxURV_MouseHover(object sender, EventArgs e)
        {
            statusLabelSensorData.Text = "Write URV-value";
        }

        private void textBoxUnit_MouseHover(object sender, EventArgs e)
        {
            statusLabelSensorData.Text = "Write unit";
        }

        private void textBoxAlarmH_MouseHover(object sender, EventArgs e)
        {
            statusLabelSensorData.Text = "Set a hight level value";
        }

        private void textBoxAlarmL_MouseHover(object sender, EventArgs e)
        {
            statusLabelSensorData.Text = "Set a low level value";
        }
        
        private void comboBoxSignalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMeasureType.Items.Clear();

            switch (comboBoxSignalType.Text)
            {
                case "Analog":
                    comboBoxMeasureType.Items.AddRange(analogSignals);
                    panelUnit.Visible = true;
                    analogIndex++;
                    break;

                case "Digital":
                    comboBoxMeasureType.Items.AddRange(digitalSignals);
                    panelUnit.Visible = false;
                    digitalIndex++;
                    break;

                case "Fieldbus":
                    comboBoxMeasureType.Items.AddRange(fieldbusSignals);
                    panelUnit.Visible = false;
                    fieldbusIndex++;
                    break;

                default:
                    break;
            }
        }
       
        private void buttonSummary_Click(object sender, EventArgs e)
        {
            System.TimeSpan sessionTime = DateTime.Now.Subtract(sessionStartTime);
            AddTextInSummaryBox(sessionTime);
            RegisterIndex = analogIndex + digitalIndex + fieldbusIndex;
            switch (comboBoxSignalType.Text)
            {
                case "Analog":
                    analogIndex++;
                    lrvValue = Convert.ToDouble(textBoxLRV.Text, CultureInfo.InvariantCulture);
                    urvValue = Convert.ToDouble(textBoxURV.Text, CultureInfo.InvariantCulture);
                    spanValue = urvValue - lrvValue;
                    AddTextInSummaryBox(sessionTime);
                    textBoxSummary.AppendText("Span Value " + spanValue + "\r\n");
                    break;

                case "Digital":
                    AddTextInSummaryBox(sessionTime);
                    digitalIndex++;
                    break;

                case "Fieldbus":
                    AddTextInSummaryBox(sessionTime);
                    fieldbusIndex++;
                    break;

                default:
                    break;

            }
        }

        private void AddTextInSummaryBox(TimeSpan sessionTime)
        {
            textBoxSummary.AppendText("Session time: " + sessionTime.TotalSeconds.ToString() + "s \r\n");
            textBoxSummary.AppendText("Number of sensors registered: " + RegisterIndex + "s \r\n");
            textBoxSummary.AppendText("Number of analog sensors " + analogIndex + "\r\n");
            textBoxSummary.AppendText("Number of digital sensors " + digitalIndex + "\r\n");
            textBoxSummary.AppendText("Number of fieldbus sensors " + fieldbusIndex + "\r\n");
        }

        private void buttonConnect_Click_1(object sender, EventArgs e)
        {
            if (textBoxIP.Text == "127.0.0.1" & textBoxPort.Text == "5000")
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(textBoxIP.Text), Convert.ToInt32(textBoxPort.Text));
                Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                client.Connect(endPoint);
                textBoxCommunication.AppendText("Connected to Server." + "\r\n");
                statusLabelConnection.Text = "Connected";
                panelMonitor.Visible = true;
                statusStripConnection.BackColor = Color.Green;
                client.Send(Encoding.ASCII.GetBytes("comport"));
                
                //client received
                byte[] buffer = new byte[1024];
                int bytesReceived = client.Receive(buffer);
                textBoxCommunication.AppendText("Received: " + Encoding.ASCII.GetString(buffer, 0, bytesReceived) + "\r\n");


                string ComPortReceived = Encoding.ASCII.GetString(buffer, 0, bytesReceived) + "\r\n";
                string[] ComportReceivedParts = ComPortReceived.Split(' ');
                string ComPortParts = ComportReceivedParts[2].Substring(0, ComportReceivedParts[2].Length-2);

                if (ComportReceivedParts.Length > 0 & ComportReceivedParts[0] == "Portname")
                {
                    if (!comboBoxComPort.Items.Contains(ComPortParts))
                    {
                        comboBoxComPort.Items.Add(ComPortParts);
                    }
                }

                client.Close();
            }

            else
            {
                statusLabelConnection.Text = "Not connected";
                statusStripConnection.BackColor = Color.Red;
                MessageBox.Show("Instrument is not connected", "No connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxIP.Focus();
            }
        }
        
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void buttonOpenFIle_Click(object sender, EventArgs e)
        {
            string fileName = "";
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "CSV files (*.csv)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                string message = "Are you sure you want to open this file?";
                string caption = "Confirm filename";
                //Creating a messagebox
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon icon = MessageBoxIcon.Question;
                DialogResult result;
                result = MessageBox.Show(this, message, caption, buttons, icon);

                if (result == DialogResult.Yes)
                {
                    comboBoxInstrumentName.Items.Clear();
                    var inputFile = new StreamReader(fileName);
                    textBoxRegister.Text = inputFile.ReadToEnd();
                    inputFile.Close();
                }
            }
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            if (textBoxRegister.TextLength > 0)
            {
                StreamWriter outputFile = new StreamWriter("Instrument.ssc");
                string[] splits = textBoxRegister.Text.Split(";");
                string split = splits[0].Substring(0, 11);
                outputFile.WriteLine(textBoxRegister.Text);
                outputFile.Close();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter outputFile = new StreamWriter(fileNameInstrumentList);
            instrumentList.ForEach(delegate (Instrument instrument)
            {
                outputFile.WriteLine(instrument.ToString());
            });
            outputFile.Close();
        }

        private void comboBoxInstrumentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxInstrumentName.SelectedIndex > -1)
            {
                foreach (var instrument in instrumentList)
                {
                    if (instrument.SensorName == comboBoxInstrumentName.Text)
                    {
                        dateTimePickerRegisterDate.Value = instrument.RegisterDate;
                        maskedTextBoxSerialNumber.Text = instrument.SerialNumber;
                        comboBoxSignalType.Text = instrument.SignalType;
                        comboBoxMeasureType.Text = instrument.MeasuremeantType;
                        comboBoxOptions.Text = instrument.Options;
                        textBoxComment.Text = instrument.Comment;
                        lrvValue = instrument.LRV;
                        urvValue = instrument.URV;
                        textBoxLRV.Text = instrument.LRV.ToString();
                        textBoxLRV.Text = instrument.URV.ToString();
                        textBoxUnit.Text = instrument.Unit;
                        break;
                    }
                }
            }
        }

        private string sendToBackEnd(string command)
        {
            if (textBoxIP.Text == "127.0.0.1")
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(textBoxIP.Text), Convert.ToInt32(textBoxPort.Text));
                Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                client.Connect(endPoint);
                client.Send(Encoding.ASCII.GetBytes(command));

                //client received
                byte[] buffer = new byte[1024];
                int bytesReceived = client.Receive(buffer);
                string received = Encoding.ASCII.GetString(buffer, 0, bytesReceived);
                string receivedPart = received.Substring(0, received.Length - 1);
                textBoxCommunication.AppendText(receivedPart + "\r\n");
                client.Close();
                return received;
            }

            else
            {
                statusLabelConnection.Text = "Not connected";
                statusStripConnection.BackColor = Color.Red;
                MessageBox.Show("Instrument is not connected", "No connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "No connection";
            }
        }

        private void buttonReadConfiguration_Click(object sender, EventArgs e)
        {
            SendToArduino("readconf");
        }

        private void SendToArduino(string commandSend)
        {
            textBoxCommunication.Clear();
            if (textBoxIP.Text == "127.0.0.1")
            {
                string[] sensorConf;
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(textBoxIP.Text), Convert.ToInt32(textBoxPort.Text));
                Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                client.Connect(endPoint);
                textBoxCommunication.AppendText("Connected to Server." + "\r\n");
                //client send
                client.Send(Encoding.ASCII.GetBytes(commandSend));
                //client received
                byte[] buffer = new byte[1024];
                int bytesReceived = client.Receive(buffer);
                textBoxCommunication.AppendText("Received: " + Encoding.ASCII.GetString(buffer, 0, bytesReceived) + "\r\n");
                //client close
                client.Close();
                textBoxCommunication.AppendText("Connection closed..." + "\r\n");
            }
            else
            {
                statusLabelConnection.Text = "Not connected";
                statusStripConnection.BackColor = Color.Red;
                MessageBox.Show("Instrument is not connected", "No connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxIP.Focus();
            }
        }

        private void buttonReadState_Click(object sender, EventArgs e)
        {
            SendToArduino("readstatus");
        }

        private void buttonReadScaled__Click(object sender, EventArgs e)
        {
            SendToArduino("readscaled");
        }

        private void timerReadScaled_Tick(object sender, EventArgs e)
        {
            DateTime timeNow = DateTime.Now;
            
            double yValue = 0.0;
            string received = sendToBackEnd("readscaled");
            string receivedY = received.Substring(0, received.Length - 1);
            yValue = Convert.ToDouble(receivedY, CultureInfo.InvariantCulture);
            chartArduino.Series[0].Points.AddXY(timeNow.ToString("HH:mm:ss"), yValue + "\r\n");
            listBoxGraph.Items.Add("Scaled: " + yValue + "\r\n" + "Time: " + timeNow + "\r\n");
        }
        

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBoxRegister.Text = "";
            comboBoxInstrumentName.Text = "";
            maskedTextBoxSerialNumber.Text = "";
            checkBoxRegistered.Checked = false;
            dateTimePickerRegisterDate.Value = DateTime.Now;
            comboBoxSignalType.SelectedIndex = -1;
            comboBoxMeasureType.Items.Clear();
            comboBoxOptions.SelectedIndex = -1;
            textBoxComment.Text = "";
            textBoxLRV.Text = "";
            textBoxURV.Text = "";
            textBoxUnit.Text = "";
            textBoxAlarmH.Text = "";
            textBoxAlarmL.Text = "";
            panelUnit.Visible = true;
        }

        private static void WriteOnlyNumbers(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxURV_KeyPress(object sender, KeyPressEventArgs e)
        {
            WriteOnlyNumbers(e);
        }

        private void textBoxLRV_KeyPress(object sender, KeyPressEventArgs e)
        {
            WriteOnlyNumbers(e);
        }
        private void textBoxAlarmH_KeyPress(object sender, KeyPressEventArgs e)
        {
            WriteOnlyNumbers(e);
        }

        private void textBoxAlarmL_KeyPress(object sender, KeyPressEventArgs e)
        {
            WriteOnlyNumbers(e);
        }

        private void textBoxIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            WriteOnlyNumbers(e);
        }

        private void buttonComConnect_Click(object sender, EventArgs e)
        {
            if (comboBoxComPort.Text != "")
            {
                serialPort.PortName = comboBoxComPort.Text;
            }

            else
            {
                MessageBox.Show("You must choose a COM Port", "No connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxBit.Text != "")
            {
                serialPort.BaudRate = Convert.ToInt32(comboBoxBit.Text);
            }
            else
            {
                MessageBox.Show("You must choose a Bitrate", "No connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            serialPort.Open();
            textBoxComReceived.Clear();
            textBoxComReceived.AppendText("Connected" + "\r\n");
            panelConf.Visible = true;
            serialPort.Close();
        }

        private void buttonWriteConfiguration_Click(object sender, EventArgs e)
        {
            textBoxCommunication.Clear();
            
            if (textBoxIP.Text == "127.0.0.1" & textBoxPassword.Text == "Password")
            {
                if (comboBoxInstrumentName.Text != "" | textBoxLRV.Text != "" | textBoxURV.Text != "" | textBoxAlarmL.Text != "" | textBoxAlarmH.Text != "")
                {
                    string instrumentConfig = "";

                    instrumentConfig = "writeconf>password>" + comboBoxInstrumentName.Text
                                                             + ";" + textBoxLRV.Text
                                                             + ";" + textBoxURV.Text
                                                             + ";" + textBoxAlarmL.Text
                                                             + ";" + textBoxAlarmH.Text;

                    sendToBackEnd(instrumentConfig);
                    textBoxCommunication.AppendText("Sucessfully written to configuration" + "\r\n");
                }
                else
                {
                    MessageBox.Show("Could not write to configuration", "No connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Could not write to configuration", "No connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStopMonitoring_Click(object sender, EventArgs e)
        {
            timerReadScaled.Stop();

            string message = "Do you want to save to file?";
            string caption = "Save values to file";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult save;

            save = MessageBox.Show(this, message, caption, buttons, icon);

            if(save == DialogResult.Yes)
            {
                using (StreamWriter writer = new StreamWriter("output.txt", true))
                {
                    foreach (DataPoint point in chartArduino.Series[0].Points)
                    {
                        xTimeValue ++;
                        writer.WriteLine("Time: " + point.AxisLabel + "Scaled value: " + point.YValues[0]);
                        writer.WriteLine("List-index: " + xTimeValue);
                    }
                }
                MessageBox.Show("Sucessfully saved to file called output");
            }
        }

        private void buttonStartMonitoring_Click(object sender, EventArgs e)
        {
            textBoxStartMonitor.AppendText("Starting monitor... " + "\r\n" + "Switch to Graph");
            timerReadScaled.Start();
        }
        
    }
}
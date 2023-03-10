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

namespace FirstWindowsFormsApp
{
    public partial class FormMain : Form
    {
        // Constants

        string[] analogSignals = new string[] { "0-5VDC", "0-10VDC", "0-15VDC", "0-20VDC" };
        string[] digitalSignals = new string[] { "5VCD", "10VDC", "15VDC", "20VDC" };
        string[] fieldbusSignals = new string[] { "Modus 1", "Modus 2", "Modus 3" };

        //Variables

        string fileNameInstrumentList = ("register.csv");

        double lrvValue = 0.0;
        double urvValue = 0.0;
        double spanValue = 0.0;
        double alarmLvalue = 0.0;
        double alamrHvalue = 0.0;

        int RegisterIndex = 0;
        int analogIndex = 0;
        int digitalIndex = 0;
        int fieldbusIndex = 0;

        DateTime sessionStartTime;

        int xTimeValue = 0;

        List<string> servers = new List<string>();
        List<Instrument> instrumentList = new List<Instrument>();

        static SerialPort serialPort;

        public FormMain()
        {
            
            
            serialPort = new SerialPort();
            serialPort.PortName = "COM3";
            serialPort.BaudRate = 9600;
            serialPort.Parity = Parity.None;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            serialPort.Handshake = Handshake.None;
            serialPort.DataReceived += dataReceived;

            //string[] ComPorts = System.IO.Ports.SerialPort.GetPortNames();
            //string[] ComPorts = SerialPort.GetPortNames();
            //string[] ComPorts = System.IO.Ports.SerialPort.GetPortNames();

            //comboBoxComPort.Items.Add(ComPorts);
            /*

            foreach (string port in ComPorts)
            {
                comboBoxComPort.Items.AddRange(ComPorts);
                //Console.WriteLine(port);
            }
            */
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
            sessionStartTime = DateTime.Now;
            statusLabelSensorData.Text = "Ready";
            comboBoxSignalType.Text = "";
            textBoxRegister.Text = "";
            //comboBoxMeasureType.Text = "";

            //Load instrument.csv file
            string instrumentLine = "";
            string[] instrumentLineParts;
            var inputFile = new StreamReader(fileNameInstrumentList);

            //Når jeg kommenterer bort dette blir lista laget i riktig form i listeboksen,
            //når jeg har det med blir det lagret nedover

            //Trenger ikke å ha med dette til Arbiedsrav 1
            /*
            if (inputFile != null)
            {
                while (!inputFile.EndOfStream)

                {
                    instrumentLine = inputFile.ReadLine();
                    instrumentLineParts = instrumentLine.Split(';');

                    Instrument instrument = new Instrument(instrumentLineParts[0],
                                                            instrumentLineParts[1],
                                                            instrumentLineParts[2],
                                                            instrumentLineParts[3],
                                                            instrumentLineParts[4],
                                                            instrumentLineParts[5],
                                                            instrumentLineParts[6],
                                                            Convert.ToDouble(instrumentLineParts[7], CultureInfo.InvariantCulture),
                                                            Convert.ToDouble(instrumentLineParts[8], CultureInfo.InvariantCulture),
                                                            instrumentLineParts[9]);

                    instrumentList.Add(instrument);
                    comboBoxInstrumentName.Items.Add(instrumentLineParts[1]);
                    //listBoxServers.Items.AddRange(instrumentLineParts.ToArray());
                    //textBoxRegister.Text = instrumentLine.ToString();
                }


                inputFile.Close();

            }
            */
        }
            
        
    private void dataReceived(object sender, SerialDataReceivedEventArgs e)
    {
        string message = serialPort.ReadLine();
        //string messsage = "COM3";
        Console.WriteLine(message);
        Console.WriteLine("Funker!");
        textBoxComReceived.AppendText("Hei" + message);
        Console.WriteLine("Funker bra");
    }
        

    // funker ikke
    private void FormMain_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '+')
            {
                this.Height += 15;
                this.Width += 2;
            }


            if (e.KeyChar == '-')
            {
                this.Height -= 15;
                this.Width -= 2;
            }
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

            if (!NewSensorName())
            {
                MessageBox.Show("This instrument already exist");
            }


            if (comboBoxInstrumentName.SelectedIndex < 0)
            {
                //MessageBox.Show("Missing instruement name");
                //comboBoxInstrumentName.Focus();
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
                    MessageBox.Show("The URV-value can not be lower than LRV-value. Enter a new URV-value.");
                    textBoxURV.Focus();
                }
            }

            //instrumentList.Add(instrument);    //For å legge til en liste i listeboksen

            AddTextInTextRegister();

            //List<InstrumentBE> instrumentList = new List<InstrumentBE>();

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

        // Metods



        //Making a list

        //public List<Instrument> instruments = new List<Instrument>();


        private void AddTextInTextRegister()
        {

            textBoxRegister.Text = "";
            //listBoxServers.Items.Clear();
            //if (NewInstrument(textBoxLabelSensorName.Text))

            if (NewInstrument(comboBoxInstrumentName.Text))
            {
                if (comboBoxSignalType.Text == "Analog")
                {
                    Instrument instrument = new Instrument(dateTimePickerRegisterDate.Text,
                                                            comboBoxInstrumentName.Text,
                                                            maskedTextBoxSerialNumber.Text,
                                                            comboBoxSignalType.Text,
                                                            comboBoxMeasureType.Text,
                                                            comboBoxOptions.Text,
                                                            textBoxComment.Text,
                                                            Convert.ToDouble(textBoxLRV.Text),
                                                            Convert.ToDouble(textBoxURV.Text),
                                                            //textBoxLRV.Text,
                                                            //textBoxURV.Text,
                                                            //lrvValue,
                                                            //urvValue,
                                                            textBoxUnit.Text,
                                                            Convert.ToDouble(textBoxAlarmL.Text),
                                                            Convert.ToDouble(textBoxAlarmH.Text)                                                        //alarmLvalue,
                                                                                                                                                        //alamrHvalue
                                                            );
                    //instrumentList.Add(instrument);
                    textBoxRegister.AppendText(instrument.ToString());
                    //listBoxServers.Append(instrument);
                    //listBoxServers.Items.Add(instrument.ToString());
                    listBoxServers.Items.Add(instrument);
                    //listBoxServers.Items.AddRange(instrument);
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
                                                            //Convert.ToDouble(textBoxLRV.Text),
                                                            //Convert.ToDouble(textBoxURV.Text),
                                                            //textBoxLRV.Text,
                                                            //textBoxURV.Text,
                                                            //lrvValue,
                                                            //urvValue,
                                                            //textBoxUnit.Text
                                                            //Convert.ToDouble(textBoxAlarmL.Text),
                                                            //Convert.ToDouble(textBoxAlarmH.Text)                                                        //alarmLvalue,
                                                                                                                                                        //alamrHvalue
                                                            );
                    //instrumentList.Add(instrument);
                    textBoxRegister.AppendText(instrument.ToString());
                    //listBoxServers.Append(instrument);
                    //listBoxServers.Items.Add(instrument.ToString());
                    listBoxServers.Items.Add(instrument);
                    //listBoxServers.Items.AddRange(instrument);

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
            textBoxRegister.Text = "";
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
            //comboBoxMeasureType.SelectedIndex = 0;      //index fungerer ikke

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

        private void textBoxLRV_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


        }

        private void buttonSummary_Click(object sender, EventArgs e)
        {
            //DateTime sessionTime;
            System.TimeSpan sessionTime = DateTime.Now.Subtract(sessionStartTime);  //lager en lokal variabel "session time"

            //Add text in Summary Box
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
            textBoxSummary.AppendText("Session time: " + sessionTime.TotalSeconds.ToString() + "s \r\n");   // beregner sessiontime i sekunder
            textBoxSummary.AppendText("Number of sensors registered: " + RegisterIndex + "s \r\n");
            textBoxSummary.AppendText("Number of analog sensors " + analogIndex + "\r\n");
            textBoxSummary.AppendText("Number of digital sensors " + digitalIndex + "\r\n");
            textBoxSummary.AppendText("Number of fieldbus sensors " + fieldbusIndex + "\r\n");
        }

        /*
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (tabControl1.SelectedIndex == 2)
            {
                listBoxServers.Items.Clear();
                listBoxServers.Items.AddRange(servers.ToArray());
            }
        }

        */
        private void buttonConnect_Click_1(object sender, EventArgs e)
        {

            if (textBoxIP.Text == "127.0.0.1")
            {

                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(textBoxIP.Text), Convert.ToInt32(textBoxPort.Text));
                Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                //if (endPoint != null)
                //{
                client.Connect(endPoint);

                textBoxCommunication.AppendText("Connected to Server.");
                statusLabelConnection.Text = "Connected";
                statusStripConnection.BackColor = Color.Green;
                //statusStripConnection.BackColor = SystemColors.Window;
                //client send
                client.Send(Encoding.ASCII.GetBytes(textBoxSend.Text));

                
                //client received
                byte[] buffer = new byte[1024];
                int bytesReceived = client.Receive(buffer);
                textBoxCommunication.AppendText("Received: " + Encoding.ASCII.GetString(buffer, 0, bytesReceived) + "\r\n");

                //Lage if-setning så bare comport blir lagt til i 

                string ComPortReceived = Encoding.ASCII.GetString(buffer, 0, bytesReceived) + "\r\n";
                string[] ComportReceivedParts = ComPortReceived.Split(' ');      //finne ut hvirdan jeg skal splitte
                string ComPortParts = ComportReceivedParts[2].Substring(0, ComportReceivedParts[2].Length);

                if(ComportReceivedParts.Length > 0 & ComportReceivedParts[0] == "Portname")
                {
                    comboBoxComPort.Items.Add(ComPortParts);
                }
                
                //comboBoxComPort.Items.Add(ComPortReceived);
                //string ComportParts= ComportReceivedParts[2].Substring(0, ComportReceivedParts[2].Length);
                //comboBoxComPort.Items.Add(ComportParts);
                //string[] ComportReceivedParts = ComPortReceived.Split("");
                //string ComportParts = ComportReceivedParts[1].Substring(0, ComportReceivedParts[1].Length - 4);
                //comboBoxComPort.Items.Add(ComportParts);
                //comboBoxComPort.Items.Add(ComPortReceived);

                //
                client.Close();
                //textBoxCommunication.AppendText("Connection closed..." + "\r\n");

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
                //toolStripStatusLabel1.Text = fileName;

                string message = "Are you sure you want to open this file?";
                string caption = "Confirm filename";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon icon = MessageBoxIcon.Question;
                DialogResult result;

                result = MessageBox.Show(this, message, caption, buttons, icon);
                if (result == DialogResult.Yes)
                {
                    var inputFile = new StreamReader(fileName);
                    textBoxRegister.Text = inputFile.ReadToEnd();
                    inputFile.Close();

                    //MessageBox.Show("Filename = " + fileName);
                }
            }
        }

        //
        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            if (textBoxRegister.TextLength > 0)
            {
                StreamWriter outputFile = new StreamWriter("register.csv");     //får ikke lagret til fil
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
        //private string sendToBackEnd(string command)
        {

            if (textBoxIP.Text == "127.0.0.1")
            {

                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(textBoxIP.Text), Convert.ToInt32(textBoxPort.Text));
                Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                client.Connect(endPoint);
                Trace.WriteLine("Connected to server..." + "\r\n");
                //client send
                textBoxCommunication.AppendText(command);
                //Console.WriteLine(command + "\r\n");

                client.Send(Encoding.ASCII.GetBytes(command));


                //client received
                byte[] buffer = new byte[1024];
                
                //Hvis bytes som kommer inn er null --> "Not connected to Arduino"
                //if (buffer.Length <= 0)
                //{
                int bytesReceived = client.Receive(buffer);
                string received = Encoding.ASCII.GetString(buffer, 0, bytesReceived);

                textBoxCommunication.AppendText(received);
                textBoxCommunication.AppendText("Received: " + Encoding.ASCII.GetString(buffer, 0, bytesReceived) + "\r\n");
                client.Close();
                textBoxCommunication.AppendText("Connection closed..." + "\r\n");
                //Trace.WriteLine("Connection closed..." + "\r\n");
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
            textBoxCommunication.Clear();
            if (textBoxIP.Text == "127.0.0.1")
            {
                string[] sensorConf;
                //string received;

                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(textBoxIP.Text), Convert.ToInt32(textBoxPort.Text));
                Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Trace.WriteLine("Connected to server..." + "\r\n");



                client.Connect(endPoint);
                textBoxCommunication.AppendText("Connected to Server.");
                statusLabelConnection.Text = "Connected";
                statusStripConnection.BackColor = Color.Green;

                //client send
                client.Send(Encoding.ASCII.GetBytes("readconf"));

                //client received
                byte[] buffer = new byte[1024];
                int bytesReceived = client.Receive(buffer);
                textBoxCommunication.AppendText("Received: " + Encoding.ASCII.GetString(buffer, 0, bytesReceived) + "\r\n");
                
                //string received = Encoding.ASCII.GetString(buffer, 0, bytesReceived);

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
            textBoxCommunication.Clear();
           
            if (textBoxIP.Text == "127.0.0.1")
            {
                string[] sensorConf;
                //string received;

                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(textBoxIP.Text), Convert.ToInt32(textBoxPort.Text));
                Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Trace.WriteLine("Connected to server..." + "\r\n");



                client.Connect(endPoint);
                textBoxCommunication.AppendText("Connected to Server.");
                statusLabelConnection.Text = "Connected";
                statusStripConnection.BackColor = Color.Green;

                //client send
                client.Send(Encoding.ASCII.GetBytes("readstatus"));

                //client received
                byte[] buffer = new byte[1024];
                int bytesReceived = client.Receive(buffer);
                textBoxCommunication.AppendText("Received: " + Encoding.ASCII.GetString(buffer, 0, bytesReceived) + "\r\n");

                //string received = Encoding.ASCII.GetString(buffer, 0, bytesReceived);

                //textBoxCommunication.AppendText("Received: " + Encoding.ASCII.GetString(buffer, 0, bytesReceived) + "\r\n");
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

        private void buttonReadScaled_Click(object sender, EventArgs e)
        {
            textBoxCommunication.Clear();
            if (textBoxIP.Text == "127.0.0.1")
            {
                string[] sensorConf;
                //string received;

                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(textBoxIP.Text), Convert.ToInt32(textBoxPort.Text));
                Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Trace.WriteLine("Connected to server..." + "\r\n");



                client.Connect(endPoint);
                textBoxCommunication.AppendText("Connected to Server.");
                statusLabelConnection.Text = "Connected";
                statusStripConnection.BackColor = Color.Green;

                //client send
                client.Send(Encoding.ASCII.GetBytes("readscaled"));

                //client received
                byte[] buffer = new byte[1024];
                int bytesReceived = client.Receive(buffer);
                textBoxCommunication.AppendText("Received: " + Encoding.ASCII.GetString(buffer, 0, bytesReceived) + "\r\n");

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

        /*
        private void buttonAddXY_Click(object sender, EventArgs e)
        {

            if (timerReadScaled.Enabled)
            {
                timerReadScaled.Stop();
            }
            else
            {
                timerReadScaled.Start();
            }

        }
        */

        private void timerReadScaled_Tick(object sender, EventArgs e)
        {
            xTimeValue++;
            //xTimeValue = DateTime.UtcNow.ToUniversalTime();
            DateTime timeNow = DateTime.Now;
            double yValue = 0.0;

            string received = sendToBackEnd("readscaled");
            string receivedY = received.Substring(0, received.Length - 2);

            yValue = Convert.ToDouble(receivedY, CultureInfo.InvariantCulture);

            //chartArduino.Series[0].Points.AddXY(xTimeValue, yValue);
            double adding = chartArduino.Series[0].Points.AddXY(timeNow.ToString("HH:mm:ss"), yValue);
            //string.Format("({0:0.00}", yValue);
            //listBoxGraphYvals.Items.Add(string.Format("{0:0.00}", yValue));
            listBoxGraphYvals.Items.Add(yValue);
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

        // Hentet fra nettet, må skrives om

        private void textBoxURV_KeyPress(object sender, KeyPressEventArgs e)
        {
            //urvValue= e.KeyChar;



            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBoxAlarmH_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(Convert.ToDouble(textBoxAlarmH.Text) )

            /*
            if(e.KeyChar < 0 || e.KeyChar < Convert.ToInt64(textBoxAlarmL.Text)) 
            {   
                e.Handled = true;
            }
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            */

        }

        private void textBoxAlarmL_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (e.KeyChar < 0 || e.KeyChar > Convert.ToDouble(textBoxAlarmL.Text))
            {
                e.Handled = true;
            }
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            */
        }

        private void buttonComConnect_Click(object sender, EventArgs e)
        {
            if (comboBoxComPort.Text != "")
            {
                serialPort.PortName = comboBoxComPort.Text;
            }

            else
            {
                return;
            }
            if (comboBoxBaud.Text != "")
            {
                serialPort.BaudRate = Convert.ToInt32(comboBoxBaud.Text);
            }
            else
            {
                return;
            }
            serialPort.Open();
            serialPort.Write(textBoxSend.Text);
            textBoxComReceived.AppendText("Hei på deg");
            //serialPort.Close();    //må jeg ha med close? Får ikke ut grafen.
        }

        private void buttonWriteConfiguration_Click(object sender, EventArgs e)
        {
            /*
            textBoxCommunication.Clear();
            if (textBoxIP.Text == "127.0.0.1" & textBoxPassword.Text == "Password")
            {
                string instrumentConfig = "";


                instrumentConfig = "writeconf>password>" + comboBoxInstrumentName.Text
                                                         + ";" + textBoxLRV.Text
                                                         + ";" + textBoxURV.Text
                                                         + ";" + textBoxAlarmL.Text
                                                         + ";" + textBoxAlarmH.Text;



                sendToBackEnd(instrumentConfig);
            }
            */
            //
            
            
            textBoxCommunication.Clear();
            if (textBoxIP.Text == "127.0.0.1" & textBoxPassword.Text == "Password")
            {
                //string received;

                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(textBoxIP.Text), Convert.ToInt32(textBoxPort.Text));
                Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Trace.WriteLine("Connected to server..." + "\r\n");



                client.Connect(endPoint);
                textBoxCommunication.AppendText("Connected to Server.");
                statusLabelConnection.Text = "Connected";
                statusStripConnection.BackColor = Color.Green;

                //
                string instrumentConfig = "";

                instrumentConfig = "writeconf>password>" + comboBoxInstrumentName.Text
                                                         + ";" + textBoxLRV.Text
                                                         + ";" + textBoxURV.Text
                                                         + ";" + textBoxAlarmL.Text
                                                         + ";" + textBoxAlarmH.Text;
                //string[] sensorConf;
                
                //

                //client send
                client.Send(Encoding.ASCII.GetBytes(instrumentConfig));
                //client.Send(Encoding.ASCII.GetBytes("writeconf"));

                //client received
                byte[] buffer = new byte[1024];
                int bytesReceived = client.Receive(buffer);
                textBoxCommunication.AppendText("Received: " + Encoding.ASCII.GetString(buffer, 0, bytesReceived) + "\r\n");


                //received = "readconf";

                //int bytesReceived = client.Receive(buffer);
                string received = Encoding.ASCII.GetString(buffer, 0, bytesReceived);

                //textBoxCommunication.AppendText("Received: " + Encoding.ASCII.GetString(buffer, 0, bytesReceived) + "\r\n");
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


            /*

            if (textBoxPassword.Text == "Password")
            {
                string received;
                received = sendToBackEnd("readscaled");
                textBoxCommunication.AppendText(received + "\r\n");
            }
            else
            {
                MessageBox.Show("Password was wrong!", "Incorrect password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        //Fungerer ikke å skrive ut grafen
        private void buttonStartMonitoring_Click(object sender, EventArgs e)
        {
            /*
            timerReadScaled.Start();
            
            using (StreamWriter writer = new StreamWriter("output.txt", true))
            {
                foreach (DataPoint point in chartArduino.Series[0].Points)
                {
                    writer.WriteLine(point.XValue.ToString("Values") + "" + point.YValues[0].ToString("Values"));
                }
            }

            */

            timerReadScaled.Start();
            /*
            using (StreamWriter writer = new StreamWriter("output.txt", true))
            {
                foreach (DataPoint point in chartArduino.Series[0].Points)
                {
                    writer.WriteLine(point.XValue.ToString("Values") + "" + point.YValues[0].ToString("Values"));
                }
            }
            /*

            if (timerReadScaled.Enabled)
            {
                timerReadScaled.Stop();
            }
            else
            {
                timerReadScaled.Start();
                
                using (StreamWriter writer = new StreamWriter("output.txt", true))
                {
                    foreach (DataPoint point in chartArduino.Series[0].Points)
                    {
                        writer.WriteLine(point.XValue.ToString("Values") + "" + point.YValues[0].ToString("Values"));
                    }
                }
            }
            */

        }

        private void buttonStopMonitoring_Click(object sender, EventArgs e)
        {
            timerReadScaled.Stop();
            //listBoxGraph.Items.Add();
            using (StreamWriter writer = new StreamWriter("output.txt", true))
            {
                foreach (DataPoint point in chartArduino.Series[0].Points)
                {
                    writer.WriteLine(point.XValue.ToString("Values") + "" + point.YValues[0].ToString("Values"));
                }
            }

        }




        //



        /*
        private void buttonRegSaveDel_Click(object sender, EventArgs e)
        {
            switch (buttonRegSaveDel.Text) 
            {
                case "Register New":

                    if (!NewSensorName()) ;
            }
            break;
        }

        private void radioButtonRegisterNew_CheckedChanged(object sender, EventArgs e)
        {
            buttonRegSaveDel.Text == "Register New";
        }
        */

    }   
}










// Hjelp til koding

//Hvordan sjekke om du har connection??

//Hvordan sjekke om instrument name ligger i listen og hvordan ikke legge til et instruemnt uten navn




//Veiledning
// if (spanValue > 0.0);

// else
//MessageBox.Show("Missing Range");

// Index for å finne tilbake til hvilket registreringsnummer for å hente tilbake og gjøre endringer

// private Boolean 
//Sensor name check
// if (textBoxSensorName.Text.Lengt==0)
//textboxSensorName.Focus()     // for å markere hvor det er feil
//return false;

//Check Range

// else
//return false;

//return false;
// return true

// RegisterIndex++  // for å øke indexen med 1



//Finpuss:
//Mouse Hover på knappene (vet ikke om jeg vil ha radiobuttons eller vanlige enda)

//Vise at man har connected med BE

//Finne ut hvordan jeg starter backend (console app) fra front end (tror ikke vi skal dette)

//Connecte LRV- og URV- verdier til arduino som gjør at LED-lyset blinker med to forskjellige frekvenser
//Gjøre så man ikke kan lagre instruement uten navn
//Gjøre så man ikke kan lagre et nytt instrument med samme serial number

//Endre navn på InstrumentFE til InstrumentForm
//Endre navn på InstrumentBE til InstrumentClass


//Kan ikke ha en connect knapp + 4 andre. Ta vekk connect og bare ha knappene



//Får ikke til å lagre til fil
//Får ikke opp grafen
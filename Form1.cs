using Microsoft.Win32;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Xml.Serialization;

namespace FirstWindowsFormsApp
{
    public partial class FormMain : Form
    {
        // Constants

        readonly int[] numbers = new int[7] { 5, 3, 7, 25, 26, 32, 43 };

        string[] analogSignals = new string[] { "0-5VDC", "0-10VDC", "0-15VDC", "0-20VDC" };
        string[] digitalSignals = new string[] { "5VCD", "10VDC", "15VDC", "20VDC" };
        string[] fieldbusSignals = new string[] { "Modus 1", "Modus 2", "Modus 3" };


        //Variables

        string fileNameInstrumentList = "register.csv";

        //char ch = 'a';
        //string surfaceArea;
        //int radius;

        double lrvValue = 0.0;
        double urvValue = 0.0;
        double spanValue = 0.0;

        int RegisterIndex = 0;
        int analogIndex = 0;
        int digitalIndex = 0;
        int fieldbusIndex = 0;

        DateTime sessionStartTime;

        List<string> servers = new List<string>();
        List<Instrument> instrumentList = new List<Instrument>();

        public FormMain()
        {
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
            toolStripStatusLabel1.Text = "Ready";
            comboBoxSignalType.Text = "";
            comboBoxSignalType.Text = "";


            //Loas instrument.csv file
            string instrumentLine = "";
            string[] instrumentLineParts;
            var inputFile = new StreamReader(fileNameInstrumentList);

            if (inputFile != null) 
            {
                while (!inputFile.EndOfStream) 
                
                {
                    instrumentLine = inputFile.ReadLine();
                    instrumentLineParts = instrumentLine.Split(';');

                    Instrument instrument = new Instrument( instrumentLineParts[0],
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

                    textBoxRegister.Text = instrumentLine.ToString();
                }

                
                inputFile.Close();

            }
        }

        private void Form1KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '+')
                this.Height += 15;
            this.Width += 2;


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

        private void button1_Click(object sender, EventArgs e)
        {
            // if (radioButtnRefisterNew.Cheched)
            //if (FormDataVerdified())
            //{ }

            //Add an index
            //RegisterIndex++;
            //textBoxRegister.AppendText(RegisterIndex + "\r\n");

            AddTexnInTextRegister();

            if (buttonRegisterNew.Text == "Register New") ;
            {
                if (comboBoxSignalType.Text == "Analog")
                {
                    if ((textBoxLRV.Text == "" || (textBoxURV.Text) == ""))
                    {
                        MessageBox.Show("Missing Range!");
                        
                        if (textBoxLRV.SelectionLength== 0)
                        {
                            MessageBox.Show("Missing Range!");
                            textBoxLRV.Focus();

                        }

                        else if (textBoxURV.SelectionLength == 0)
                        {
                            MessageBox.Show("Missing Range!");
                            textBoxURV.Focus();

                        }

                        
                    }


                }


            }

            if (buttonRegisterNew.Text == "Delete")
            {
                textBoxRegister.Text = "";
                textBoxLabelSensorName.Text = "";
                maskedTextBoxSerialNumber.Text = "";
                checkBoxRegistered.Checked = false;
                comboBoxSignalType.Text = "";
                listboxOptions.Text = "";
                textBoxComment.Text = "";
            }

            if (buttonRegisterNew.Text == "Save Changes")
            {
                textBoxRegister.Text = "";
                AddTexnInTextRegister();
            }

            RegisterIndex++;

        }

        private void AddTexnInTextRegister()
        {
            if (NewInstrument(textBoxLabelSensorName.Text))
            {



                Instrument instrument = new Instrument(textBoxLabelSensorName.Text,
                                                        maskedTextBoxSerialNumber.Text,
                                                        comboBoxSignalType.Text,
                                                        comboBoxMeasureType.Text,
                                                        listboxOptions.Text,
                                                        textBoxComment.Text,
                                                        lrvValue,
                                                        urvValue,
                                                        textBoxUnit.Text);
                instrumentList.Add(instrument);
                textBoxRegister.AppendText(instrument.ToString());
            }

            else
            {
                MessageBox.Show("Sensor Name exist", "Register Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxLabelSensorName.Focus();
            }

            /*
            textBoxRegister.AppendText("+RegisterIndex+ "] +)
            textBoxRegister.AppendText("Sensor Name: " + textBoxLabelSensorName.Text + "\r\n");
            textBoxRegister.AppendText("Serial Number: " + maskedTextBoxSerialNumber.Text + "\r\n");
            textBoxRegister.AppendText("Registered: " + checkBoxRegistered.Checked + "\r\n");
            textBoxRegister.AppendText("Register Date: " + dateTimePickerRegisterDate.Text + "\r\n");
            textBoxRegister.AppendText("Signal Type: " + comboBoxSignalType.Text + "\r\n");
            textBoxRegister.AppendText("Options: " + listboxOptions.Text + "\r\n");
            textBoxRegister.AppendText("Comment: " + textBoxComment.Text + "\r\n");
            */
        }

        public bool NewInstrument(string sensorName)
        {
            bool newInstrument = true;
            instrumentList.ForEach(delegate (Instrument instrument)
            {
                if (instrument.SensorName== sensorName)
                {
                    newInstrument= false;
                }

            });
            return newInstrument;
        }

        private void radioButtonDelete_CheckedChanged(object sender, EventArgs e)
        {
            buttonRegisterNew.Text = "Delete";
        }

        private void radioButtonSaveChanges_CheckedChanged(object sender, EventArgs e)
        {
            buttonRegisterNew.Text = "Save Changes";
        }

        private void radioButtonRegisterNew_CheckedChanged(object sender, EventArgs e)
        {
            buttonRegisterNew.Text = "Register New";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            
            
            
            
            
            //compare two text inputs
            //bool textEqual = false;

            if (checkBoxCaseSensitive.Checked)
            {
                //textEqual = textBox1.Text.Equals(textBox2.Text);
                textBoxCommunication.Text = textBoxPort.Text.Equals(textBoxIP.Text) ? "String are equal\r\n" : "Strings are not equal\r\n";
            }

            else
            {
                //textEqual = textBox1.Text.Equals(textBox2.Text, StringComparison.InvariantCultureIgnoreCase);
                textBoxCommunication.Text = textBoxPort.Text.Equals(textBoxIP.Text, StringComparison.InvariantCultureIgnoreCase) ? "String are equal\r\n" : "Strings are not equal\r\n";
            }

            int stringCompareResult;

            stringCompareResult = string.Compare(textBoxPort.Text, textBoxIP.Text, checkBoxCaseSensitive.Checked);

            if (stringCompareResult > 0)
            {
                textBoxCommunication.AppendText(string.Format("{0} is after {1}", textBoxPort.Text, textBoxIP.Text));
            }

            else if (stringCompareResult < 0)
            {
                textBoxCommunication.AppendText(string.Format("{0} is before {1}", textBoxPort.Text, textBoxIP.Text));
            }

            else
            {
                textBoxCommunication.AppendText(string.Format("{0} is equal to {1}", textBoxPort.Text, textBoxIP.Text));
            }

            if (textBoxIP.Text.IndexOf(';') > 0)
            {
                string[] textSeperateParts = textBoxIP.Text.Split(';');

                foreach (string part in textSeperateParts)
                {
                    textBoxCommunication.AppendText("\r\n" + part);
                }


            }


            /*
            if (textEqual)
            {
                textBoxResult.Text = "Strings are equal";
            }
            else
            {
                textBoxResult.Text = "Strings are not equal";
            }

            */


            //Int64 testIntLong = Convert.ToInt64(textBox2.Text);

            //uint testInt = (uint)testIntLong;

            //textBoxResult.AppendText(""+testInt);

            //int radius = 5;
            // radius = Convert.ToInt32(textBox2.Text);
            //double surface = Math.PI * Math.Pow(radius, 2);
            //string surfaceArea = "Circle surface area= ";

            //for (int i = 0; i < 10; i++)
            //{
            //textBoxResult.AppendText("" + i + "\r\n");
            //}

            //string[] seperateParts = { "Unit345", "10.0" };

            //foreach (string seperatePart in seperateParts)
            //{
            ///textBoxResult.AppendText(seperatePart + "\r\n");
            //seperateParts.Append
            //}

            //int test = 53;
            //ch = (char)test;
        }

        private void textBoxLabelSensorName_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter sensor name";
        }

        private void tabControl1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Ready";
        }

        private void maskedTextBoxSerialNumber_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Enter serial number";
        }

        private void tabPage1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Ready";
        }

        private void checkBoxRegistered_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Check out if registered";
        }

        private void dateTimePickerRegisterDate_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Choose register date";
        }

        private void comboBoxSignalType_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Choose Signal Type";
        }

        private void textBoxComment_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Write comment";
        }

        private void listboxOptions_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Choose options";
        }

        private void comboBoxSignalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMeasureType.Items.Clear();
            comboBoxMeasureType.Text = "";
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
            //try
            //{
            //if (textBoxLRV.Text != (double)) ;

        }

        private void buttonSummary_Click(object sender, EventArgs e)
        {



            //DateTime sessionTime;
            System.TimeSpan sessionTime = DateTime.Now.Subtract(sessionStartTime);  //lager en lokal variabel "session time"

            //Add text in Summary Box
            AddTextInSummaryBox(sessionTime);

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






            //Calculate span value
            //if (spanValue > 0)
            //{


            //Counting signaltypes

        }

        private void AddTextInSummaryBox(TimeSpan sessionTime)
        {
            textBoxSummary.AppendText("Session time: " + sessionTime.TotalSeconds.ToString() + "s \r\n");   // beregner sessiontime i sekunder
            textBoxSummary.AppendText("Number of sensors registered: " + RegisterIndex + "s \r\n");
            textBoxSummary.AppendText("Number of analog sensors " + analogIndex + "\r\n");
            textBoxSummary.AppendText("Number of digital sensors " + digitalIndex + "\r\n");
            textBoxSummary.AppendText("Number of fieldbus sensors " + fieldbusIndex + "\r\n");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex ==2)
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(servers.ToArray());
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(textBoxIP.Text), Convert.ToInt32(textBoxPort.Text));
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            client.Connect(endPoint);

            textBoxCommunication.AppendText("Connected to Server.");

            //client send
            client.Send(Encoding.ASCII.GetBytes(textBoxSend.Text));

            //client received
            byte[] buffer = new byte[1024];
            int bytesReceived = client.Receive(buffer);
            textBoxCommunication.AppendText("Received: " + Encoding.ASCII.GetString(buffer, 0, bytesReceived));
            client.Close();
            textBoxCommunication.AppendText("Connection closed...");
        }


        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();

        }

        private void buttonOpenFIle_Click(object sender, EventArgs e)
        {
            string fileName="";

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "CSV files (*.csv)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName= openFileDialog1.FileName;
                //toolStripStatusLabel1.Text = fileName;

                string message = "Are you sure you want to open this file?";
                string caption = "Confirm filename";
                MessageBoxButtons buttons= MessageBoxButtons.YesNo;
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

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            if (textBoxRegister.TextLength>0)
            {
                StreamWriter outputFile = new StreamWriter("register.csv");
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
                        listboxOptions.Text = instrument.Options;
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
                
                {
                    

               
            }
        }
    }

}




// Hjelp til koding
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

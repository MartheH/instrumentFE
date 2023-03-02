using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;
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

        int RegisterIndex = 0;
        int analogIndex = 0;
        int digitalIndex = 0;
        int fieldbusIndex = 0;

        DateTime sessionStartTime;

        int xTimeValue = 0;

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
            textBoxRegister.Text = "";
            //comboBoxMeasureType.Text = "";


            //Load instrument.csv file
            string instrumentLine = "";
            string[] instrumentLineParts;
            var inputFile = new StreamReader(fileNameInstrumentList);

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

                    textBoxRegister.Text = instrumentLine.ToString();
                }


                inputFile.Close();

            }

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

            AddTextInTextRegister();
            
            if (comboBoxInstrumentName.SelectedIndex <0)
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
                

                else if (textBoxURV.Text== "")
                {
                    MessageBox.Show("Missing URV-range");
                    textBoxURV.Focus();
                }
            }



                    if (textBoxLRV.SelectionLength == 0)
                    {
                        //MessageBox.Show("Missing Range!");
                        //textBoxLRV.Focus();

                    }
                    /*
                    else if (textBoxURV.SelectionLength == 0)
                    {
                        MessageBox.Show("Missing Range!");
                        textBoxURV.Focus();

                    }
                    
                    //
                    

                    switch (buttonRegisterNew.Text)
                    {
                        case "RegisterNew":
                            AddTexnInTextRegister();
                            break;

                        case "Delete":
                            textBoxRegister.Text = "";
                            //textBoxLabelSensorName.Text = "";
                            comboBoxInstrumentName.Text = "";
                            maskedTextBoxSerialNumber.Text = "";
                            checkBoxRegistered.Checked = false;
                            comboBoxSignalType.Text = "";
                            listboxOptions.Text = "";
                            textBoxComment.Text = "";
                            break;

                        case "Fieldbus":
                            comboBoxMeasureType.Items.AddRange(fieldbusSignals);
                            panelUnit.Visible = false;
                            fieldbusIndex++;
                            break;

                        default:
                            break;


                    if (buttonRegisterNew.Text == "Register New") ;
            {
                


                    }

                            */

      /*
            if (buttonRegisterNew.Text == "Save Changes")
            {
                textBoxRegister.Text = "";
                AddTextInTextRegister();
            }

            RegisterIndex++;
      */
        }
      
    
        // Metods
        private void AddTextInTextRegister()
        {
            textBoxRegister.Text = "";
            //if (NewInstrument(textBoxLabelSensorName.Text))
            if (NewInstrument(comboBoxInstrumentName.Text))
                {

                Instrument instrument = new Instrument( comboBoxInstrumentName.Text,
                                                        maskedTextBoxSerialNumber.Text,
                                                        comboBoxSignalType.Text,
                                                        comboBoxMeasureType.Text,
                                                        comboBoxOptions.Text,
                                                        textBoxComment.Text,
                                                        lrvValue,
                                                        urvValue,
                                                        textBoxUnit.Text);
                instrumentList.Add(instrument);
                textBoxRegister.AppendText(instrument.ToString());
            }
            // else if (NewInstrument(comboBoxInstrumentName.Text) == comboBoxInstrumentName) { }
            else
            {
                MessageBox.Show("Instrument name exist", "Register Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxInstrumentName.Focus();
            }

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


        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            textBoxRegister.Text = "";
            AddTextInTextRegister();

        }

            //compare two text inputs

            /*

            if (checkBoxCaseSensitive.Checked)
            {
                
                textBoxCommunication.Text = textBoxPort.Text.Equals(textBoxIP.Text) ? "String are equal\r\n" : "Strings are not equal\r\n";
            }

            else
            {
                
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
            */

        // MouseHover
        private void comboBoxInstrumentName_MouseHover(object sender, EventArgs e)
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
            toolStripStatusLabel1.Text = "Choose signal type";
        }

        private void textBoxComment_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Write comments";
        }

        private void comboBoxMeasureType_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Choose measure type";
        }

        private void comboBoxOptions_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Choose options";
        }

        private void textBoxLRV_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Write LRV-value";
        }

        private void textBoxURV_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Write URV-value";
        }

        private void textBoxUnit_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Write unit";
        }

        private void textBoxAlarmH_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Set a hight level value";
        }

        private void textBoxAlarmL_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Set a low level value";
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
        /*
        private void comboBoxMeasureType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxMeasure.Text)
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
        */
        
        private void textBoxLRV_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            //try
            //{
            //if (textBoxLRV.Text != double)
            //{
            //textBoxLRV.Focus();

            //}

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
            
            if (tabControl1.SelectedIndex == 2)
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

            textBoxCommunication.AppendText("Received: " + Encoding.ASCII.GetString(buffer, 0, bytesReceived) + "\r\n");
            client.Close();
            textBoxCommunication.AppendText("Connection closed..." + "\r\n");
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

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            if (textBoxRegister.TextLength > 0)
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



        private void buttonReadConfiguration_Click(object sender, EventArgs e)
        {
            string[] sensorConf;
            string received;
            received = sendToBackEnd("readconf");
            sensorConf = received.Split(';');
            textBoxCommunication.AppendText(sendToBackEnd(received) + "\r\n");

            string caption = "";

            foreach (string conf in sensorConf)
            {
                caption = conf + "\r\n";
            }

            MessageBox.Show(caption, "Sensor Configuration", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }


        private string sendToBackEnd(string command)
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(textBoxIP.Text), Convert.ToInt32(textBoxPort.Text));
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            client.Connect(endPoint);

            Trace.WriteLine("Connected to Server..." + "\r\n");

            //client send
            client.Send(Encoding.ASCII.GetBytes(command));

            //client received
            byte[] buffer = new byte[1024];
            int bytesReceived = client.Receive(buffer);
            string received = Encoding.ASCII.GetString(buffer, 0, bytesReceived);

            textBoxCommunication.AppendText("Received: " + Encoding.ASCII.GetString(buffer, 0, bytesReceived) + "\r\n");
            client.Close();
            Trace.WriteLine("Connection closed..." + "\r\n"); 
            return received;

        }
    private void buttonReadState_Click(object sender, EventArgs e)
    {
            string received;
            received = sendToBackEnd("readstatus");
            textBoxCommunication.AppendText(received + "\r\n");
    }

        private void buttonReadScaled_Click(object sender, EventArgs e)
        {
            string received;
            received = sendToBackEnd("readscaled");
            textBoxCommunication.AppendText(received + "\r\n");

        }

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

        private void timerReadScaled_Tick(object sender, EventArgs e)
        {
            xTimeValue++;
            double yValue = 0.0;

            string received = sendToBackEnd("readscaled");
            string[] revceivedParts = received.Split(';');
            string receivedY = revceivedParts[1].Substring(0, revceivedParts[1].Length - 2);

            yValue = Convert.ToDouble(receivedY, CultureInfo.InvariantCulture);

            chart1.Series[0].Points.AddXY(DateTime.Now, yValue);
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
            textBoxUnit.Text= "";
            textBoxAlarmH.Text = "";
            textBoxAlarmL.Text = "";
            panelUnit.Visible = true;
        }

        private void textBoxURV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (urvValue <= lrvValue)
            {
                textBoxURV.Focus();
            }
        }


    }
        
    }









// Hjelp til koding

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
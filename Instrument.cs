using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWindowsFormsApp
{
    
    internal class Instrument
    {


        public DateTime RegisterDate { get; }

        private string sensorName; //field

        public string SensorName //property 
        {
            set { sensorName = value; }
            get { return sensorName; }
        }

        public string SerialNumber { get; set; }
        public string SignalType { get; set; }
        public string MeasuremeantType { get; set; }
        public string Options { get; set; }
        public string Comment { get; set; }

        public double LRV { get; set; }
        public double URV { get; set; }
        public string Unit { get; set; }

        public double AlarmLow { get; set; }

        public double AlarmHigh { get; set; }

        public Instrument(  string RegisterDate,
                           string SensorName,
                           string SerialNumber,
                           string SignalType,
                           string MeasuremeantType,
                           string Options,
                           string Comment)
                           //double lrv = 0.0,        //disse kan vel ikke være null? Feilmedling hvis jeg tar vekk nullene. Hvorfor?
                           //double urv = 0.0,        //disse kan vel ikke være null?
                           //string unit = null,      
                           //double alarmLow = 0.0,   //disse kan vel ikke være null?     
                           //double alarmHigh = 0.0) //disse kan vel ikke være null?
        {
            this.RegisterDate = DateTime.Now;
            this.SensorName = SensorName;
            this.SerialNumber = SerialNumber;
            this.SignalType = SignalType;
            this.MeasuremeantType = MeasuremeantType;
            this.Options = Options;
            this.Comment = Comment;
            //this.LRV = lrv;
            //this.URV = urv;
            //this.Unit = unit;
            //this.AlarmLow = alarmLow;
            //this.AlarmHigh = alarmHigh;
        }
        /*
        public Instrument(string registerDate,          //Hvorfor to "Instrument"
                          string sensorName,
                          string serialNumber,
                          string signalType,
                          string measuremeantType,
                          string options = null,
                          string comment = null,
                          double lrv = 0.0,         //disse kan vel ikke være null?
                          double urv = 0.0,         //disse kan vel ikke være null?
                          string unit = null,
                          double alarmLow = 0.0,    //disse kan vel ikke være null?
                          double alarmHigh = 0.0)   //legge til alarm l og alarm h
        {
            this.RegisterDate = Convert.ToDateTime(registerDate);
            this.SensorName = sensorName;
            this.SerialNumber = serialNumber;
            this.SignalType = signalType;
            this.MeasuremeantType = measuremeantType;
            this.Options = options;
            this.Comment = comment;
            this.LRV = lrv;
            this.URV = urv;
            this.Unit = unit;
            this.AlarmLow = alarmLow;
            this.AlarmHigh = alarmHigh;
        }
        */
        //
        public Instrument(string RegisterDate,          //Hvorfor to "Instrument"
                         string SensorName,
                         string SerialNumber,
                         string SignalType,
                         string MeasuremeantType,
                         string Options,
                         string Comment,
                         double LRV,         //disse kan vel ikke være null?
                         double URV,         //disse kan vel ikke være null?
                         string Unit,
                         double AlarmLow,    //disse kan vel ikke være null?
                         double AlarmHigh)   //legge til alarm l og alarm h
        {
            this.RegisterDate = Convert.ToDateTime(RegisterDate);
            this.SensorName = SensorName;
            this.SerialNumber = SerialNumber;
            this.SignalType = SignalType;
            this.MeasuremeantType = MeasuremeantType;
            this.Options = Options;
            this.Comment = Comment;
            this.LRV = LRV;
            this.URV = URV;
            this.Unit = Unit;
            this.AlarmLow = AlarmLow;
            this.AlarmHigh = AlarmHigh;

        }
        //







            public double Span()            // 0 refrenced? Hvorfor?
        {
            return URV - LRV;
        }

        public override string ToString()
        {
            return RegisterDate.ToString() + ";" + SensorName
                                            + ";" + SerialNumber
                                            + ";" + SignalType
                                            + ";" + MeasuremeantType
                                            + ";" + Options
                                            + ";" + Comment
                                            + ";" + Convert.ToString(LRV, CultureInfo.InvariantCulture)
                                            + ";" + Convert.ToString(URV, CultureInfo.InvariantCulture)
                                            + ";" + Unit
                                            + ";" + AlarmLow
                                            + ";" + AlarmHigh;
        }
    }
}

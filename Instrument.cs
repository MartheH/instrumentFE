﻿using System;
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
            set {  sensorName = value; }
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

        public Instrument( string sensorName,
                           string serialNumber,
                           string signalType,
                           string measuremeantType,
                           string options = null,
                           string comment = null,
                           double lrv= 0.0,
                           double urv= 0.0,
                           string unit= null) 
        {
            this.RegisterDate= DateTime.Now;
            this.SensorName = sensorName;
            this.SerialNumber= serialNumber;  
            this.SignalType= signalType;
            this.MeasuremeantType= measuremeantType;
            this.Options= options;
            this.Comment= comment;
            this.LRV= lrv;
            this.URV= urv;
            this.Unit = unit;
        }

        public Instrument(string registerDate,
                          string sensorName,
                          string serialNumber,
                          string signalType,
                          string measuremeantType,
                          string options = null,
                          string comment = null,
                          double lrv = 0.0,
                          double urv = 0.0,
                          string unit = null)
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
        }

        public double Span()
        {
            return URV - LRV;
        }

        public override string ToString()
        {
            return RegisterDate.ToString()  + ";" + SensorName
                                            + ";" + SerialNumber
                                            + ";" + SignalType
                                            + ";" + MeasuremeantType
                                            + ";" + Options
                                            + ";" + Comment
                                            + ";" + Convert.ToString(LRV, CultureInfo.InvariantCulture)
                                            + ";" + Convert.ToString(URV, CultureInfo.InvariantCulture)
                                            + ";" + Unit;
        }
    }
}

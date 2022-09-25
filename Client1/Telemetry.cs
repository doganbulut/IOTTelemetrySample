using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client1
{
    public class Telemetry
    {
        public double PowerConsumption { get; set; }
        public double servoTemperature { get; set; }
        public double Vibration { get; set; }
        public bool Error { get; set; }
        public bool Working { get; set; }
        public string OverPower { get; set; }
        public string OverTemp { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]
    public class LoadbankModel
    {
        public String Name { get; set; }
        public float Power { get; set; }
        public float Resistance { get; set; }
        public float MinInputVoltage { get; set; }
        public float MaxInputVoltage { get; set; }
        public float MaxCurrent { get; set; }

        public LoadbankModel(string _name, float _P, float _minV, float _maxV)
        {
            Name = _name;
            Power = _P * 1000;
            MinInputVoltage = _minV;
            MaxInputVoltage = _maxV;
            MaxCurrent = Power / MaxInputVoltage;
            Resistance = MaxInputVoltage / MaxCurrent;
        }

 
        public void UpdateValues(string _name, float _power, float _minVolt, float _maxVolt)
        {
            Name = _name;
            Power = _power * 1000;
            MinInputVoltage = _minVolt;
            MaxInputVoltage = _maxVolt;
            MaxCurrent = Power / MaxInputVoltage;
            Resistance = MaxInputVoltage / MaxCurrent;
        }

        public LoadbankModel()
        {
            // blank constructor for use with new creation
        }
    }
}

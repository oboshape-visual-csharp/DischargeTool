using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Will store the details for each cell type
    /// </summary>
    [Serializable]
    public class CellModel
    { 
        public string   CellName { get; set; }
        public double   NominalVoltage { get; set; }
        public double    EtvVoltage { get; set; }

        //class constructor
        public CellModel(string _name, double _nomVolts, double _etvVoltage)
        {
            CellName = _name;
            NominalVoltage = _nomVolts;
            EtvVoltage = _etvVoltage;
        }
    }
}

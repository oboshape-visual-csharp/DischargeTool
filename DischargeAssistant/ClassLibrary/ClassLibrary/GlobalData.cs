using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    /// <summary>
    /// serialzable class just to store global app data in a binary file
    /// </summary>
    [System.Serializable]
   public static class GlobalData
    {
        // static loadbank data object for use in app
        public static List<LoadbankModel> LoadbankDataList = new List<LoadbankModel>();
        public static string loadbankDataFileName = "LoadbankDataFile.bin";

        // static battery cell data object for use
        public static List<CellModel> batteryCellDataList = new List<CellModel>();
        public static string batteryCellDataFileName = "CellDataFile.bin";

        // static battery string information 
        public static BatteryStringObject selectedBatteryString = null;

    }

   
    public class BatteryStringObject
    {
        // this is the object that holds the string to be created
        CellModel stringBlockType = null;
        double stringEtvVoltage = 0;
        int stringCellCount = 0;

        // calculated variables
        public double GetStringETV()
        {
            return stringEtvVoltage;
        }

        public double GetStringNomVolts()
        {
            return stringBlockType.NominalVoltage * stringCellCount;
        }

        public int GetStringCount()
        {
            return stringCellCount;
        }

        public CellModel GetBlockType()
        {
            return stringBlockType;
        }


        // method to populate string
        public BatteryStringObject(CellModel _type, int _cellCount)
        {
            stringCellCount = _cellCount;
            stringBlockType = _type;
            stringEtvVoltage = _type.EtvVoltage * _cellCount;
            
        }
    }
}

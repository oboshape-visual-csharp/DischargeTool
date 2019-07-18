using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public static class Utility
    {
        //------------------------------------------------
        //    SAVE THE NEW LOADBANK DATA TO FILE
        //------------------------------------------------
        public static void  SaveInitialLoadbankobjectToDisk(LoadbankModel loadbank)
        {
            GlobalData.LoadbankDataList.Add(loadbank);
            // now serialise back to the file
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(GlobalData.loadbankDataFileName, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, GlobalData.LoadbankDataList);
            stream.Close();
        }

        //------------------------------------------------
        //    SAVE THE  LOADBANK DATA TO FILE
        //------------------------------------------------
        public static void SaveLoadbankListToFile()
        {
            // now serialise back to the file
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(GlobalData.loadbankDataFileName, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, GlobalData.LoadbankDataList);
            stream.Close();
        }
        //------------------------------------------------
        //    READ THE LOADBANK DATA FROM FILE
        //------------------------------------------------
        public static void ReadLoadbankData()
        {
            // read the loadbank data file
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(GlobalData.loadbankDataFileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            GlobalData.LoadbankDataList = (List<LoadbankModel>)formatter.Deserialize(stream);
            stream.Close();
        }

        //------------------------------------------------
        //    CHECK TO SEE IF THERE IS A LOADBANK DATA FILE
        //------------------------------------------------
        public static bool DoesLoadbankFileExist()
        {
            // check to see if the loadbank file exists
            return File.Exists(GlobalData.loadbankDataFileName) ? true : false;
        }

        //------------------------------------------------
        //  EDIT THE LOADBANK DATA BASED ON INDEX
        //------------------------------------------------
        public static void UpdateLoadbank(int _index, string _name, float _power, float _minVolt, float _maxVolt)
        {
            GlobalData.LoadbankDataList[_index].UpdateValues( _name,  _power,  _minVolt,  _maxVolt);
        }





        //------------------------------------------------
        //    CHECK TO SEE IF THERE IS A BLOCK DATA FILE
        //------------------------------------------------
        public static bool DoesBlockDataFileExist()
        {
            // check to see if the loadbank file exists
            return File.Exists(GlobalData.batteryCellDataFileName) ? true : false;
        }

        //------------------------------------------------
        //    SAVE THE  Cell DATA TO FILE
        //------------------------------------------------
        public static void SaveCellDataListToFile()
        {
            // now serialise back to the file
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(GlobalData.batteryCellDataFileName, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, GlobalData.batteryCellDataList);
            stream.Close();
        }

        //------------------------------------------------
        //    READ THE CELL DATA FROM FILE
        //------------------------------------------------
        public static void ReadCellData()
        {
            // read the loadbank data file
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(GlobalData.batteryCellDataFileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            GlobalData.batteryCellDataList = (List<CellModel>)formatter.Deserialize(stream);
            stream.Close();
        }

        //------------------------------------------------
        //    CHECK IF THE CELL DATA FILE IS EMPTY OR NOT
        //------------------------------------------------
        public static bool IsCellDatafileEmpty()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(GlobalData.batteryCellDataFileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            bool isFileSizeZero = (stream.Length > 0) ? false : true;
            bool isStreamEmpty = false;

            try
            {
                GlobalData.batteryCellDataList = (List<CellModel>)formatter.Deserialize(stream);
                if (GlobalData.batteryCellDataList.Count == 0)
                {
                    isStreamEmpty = true;

                }
                stream.Close();
            }
            catch (SerializationException e)
            {

              //Console.WriteLine("error in reading file : error " + e.ToString());
                stream.Close();
            }


            if (isStreamEmpty == true || isFileSizeZero == true)
            {
                //Console.WriteLine("Returning true");
                return true;
            }
            else
            {
                //Console.WriteLine("Returning false");
                return false;
            }
            
        }

    }
}

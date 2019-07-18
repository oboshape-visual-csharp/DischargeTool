using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace DischargeAssistant
{
    public partial class LoadBankForm : Form
    {
        private bool createNewBank = false;
        private int m_loadbankIndex = -1;

        string _name;
        float _power;
        ushort _minVolts;
        ushort _maxVolts;

        public LoadbankModel TempLoadbank { get; set; }

        public LoadBankForm()
        {
            InitializeComponent();
            
            
        }


        //-------------------------------------------------
        //  VALIDATE ALL ENTRIES IN THE FORM
        //-------------------------------------------------
        private bool ValidateForm()
        {
            bool output = true;

           

            // check that all the textboxes arent a zero length
            if (loadbankNameTextBox.Text.Trim().Length == 0) { output = false;  }
            if (loadbankPowerTextbox.Text.Trim().Length == 0) { output = false; }
            if (minVoltageTextBox.Text.Trim().Length == 0) { output = false; }
            if (MaxVoltageTextbox.Text.Trim().Length == 0) { output = false; }

            //  now check for input validity
            _name = loadbankNameTextBox.Text.Trim().ToString();
            output = float.TryParse(loadbankPowerTextbox.Text.Trim(), out _power);
            output = ushort.TryParse(minVoltageTextBox.Text.Trim(), out _minVolts);
            output = ushort.TryParse(MaxVoltageTextbox.Text.Trim(), out _maxVolts);

            // default return if all is ok to this point
            return output;
        }
 

        public void newLoadbankFormState( bool newBankNeeded = false)
        {
            if (newBankNeeded)
            {
                createNewBank = true;
                CreateEditButton.Text = "Create";
                MainTitleLabel.Text = "New Loadbank";
                DeleteLoadbankButton.Visible = false;

                ClearFields();
            }
            else
            {
                createNewBank = false;
                CreateEditButton.Text = "Save";
                MainTitleLabel.Text = "Edit Loadbank";
                DeleteLoadbankButton.Visible = true;
            }
        }

        private void CreateEditButton_Click(object sender, EventArgs e)
        {

            // this is the section for creating new loadbanks
            if (createNewBank == true)
            {
                if (GlobalData.LoadbankDataList == null)
                {
                    GlobalData.LoadbankDataList = new List<LoadbankModel>();
                }

                if(ValidateForm())
                {
                    Utility.SaveInitialLoadbankobjectToDisk(new LoadbankModel(_name, _power, _minVolts, _maxVolts));
                    Utility.ReadLoadbankData();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please check all fields are validly populated!");
                }
            }
            else
            {
                // this is the bit for updating the loadbank data
                if (ValidateForm())
                {
                    Utility.UpdateLoadbank(m_loadbankIndex, _name, _power, _minVolts, _maxVolts);
                    Utility.SaveLoadbankListToFile();
                    Utility.ReadLoadbankData();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please check all fields are validly populated!");
                }
            }

        }


        private void ClearFields()
        {
            loadbankNameTextBox.Text = "";
            loadbankPowerTextbox.Text = "";
            minVoltageTextBox.Text = "0";
            MaxVoltageTextbox.Text = "";
        }

        //-------------------------------------------------
        //  pass the loadbank in and populate fields
        //-------------------------------------------------
        public void PassInLoadbankIndex(int loadbankIndex)
        {
            m_loadbankIndex = loadbankIndex;
            loadbankNameTextBox.Text = GlobalData.LoadbankDataList[loadbankIndex].Name;
            loadbankPowerTextbox.Text = (GlobalData.LoadbankDataList[loadbankIndex].Power/1000).ToString();
            minVoltageTextBox.Text = GlobalData.LoadbankDataList[loadbankIndex].MinInputVoltage.ToString();
            MaxVoltageTextbox.Text = GlobalData.LoadbankDataList[loadbankIndex].MaxInputVoltage.ToString();
        }

        private void DeleteLoadbankButton_Click(object sender, EventArgs e)
        {
            DialogResult result =
                    MessageBox.Show("Are you sure you want to delete the Loadbank?", "Delete Loadbank : " + GlobalData.LoadbankDataList[m_loadbankIndex].Name,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                // delete the loadbank and refresh list
                GlobalData.LoadbankDataList.RemoveAt(m_loadbankIndex);
                Utility.SaveLoadbankListToFile();
                Utility.ReadLoadbankData();
                this.Close();
            }
            
            if (result == DialogResult.No)
            {
                // just return to the main form
                this.Close();
            }
        }
    }
}

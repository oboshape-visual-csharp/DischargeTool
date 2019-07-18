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
    public partial class DischargeMainForm : Form
    {
        // this is the index of the loadbank selected
        int IndexOfSelected = -1;

        public DischargeMainForm()
        {
            InitializeComponent();
        }

        private void DischargeMainForm_Load(object sender, EventArgs e)
        {
            // when the form loads, check to see if there is a loadbank data file
            if(Utility.DoesLoadbankFileExist())
            {
                // read the file
                Utility.ReadLoadbankData();

                // is the file null
                if (GlobalData.LoadbankDataList.Count != 0)
                {
                    // populate the main screen loadbank dropdown
                    ShowLoadbanksInDropDown();
                }
                else
                {
                    CreateNewLoadbank();
                }
            }
            else
            {
                CreateNewLoadbank();
            }
        }

        public void CreateNewLoadbank()
        {
            DialogResult result =
                    MessageBox.Show("No loadbanks created, please create one!", "First Time Setup Required..",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);

            if (result == DialogResult.OK)
            {
                // create a new loadbank
                LoadBankForm frmLoadbanks = new LoadBankForm();
                frmLoadbanks.newLoadbankFormState(true);
                frmLoadbanks.ShowDialog();
            }
           
        }

        public void ShowLoadbanksInDropDown()
        {
            loadBankDropDown.DataSource = GlobalData.LoadbankDataList;
            loadBankDropDown.DisplayMember = "Name";
            loadBankDropDown.ValueMember = "Name";
        }

        private void DischargeMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewLoadbankButton_Click(object sender, EventArgs e)
        {
            // create a new loadbank
            LoadBankForm frmLoadbanks = new LoadBankForm(); // initialise
            frmLoadbanks.newLoadbankFormState(true); // call a method on the form
            frmLoadbanks.ShowDialog(); // then show it ;)
            OutputResultsLabel.Text = "";
        }

        private void DischargeMainForm_Activated(object sender, EventArgs e)
        {
            // disable edit if bank list is empty, otherwise enable
            if (GlobalData.LoadbankDataList.Count > 0)
            {
                editLoadbanksButton.Enabled = true;
            }
                
            else
            {
                // disable the edit button and clear the text from dropdown
                editLoadbanksButton.Enabled = false;
                loadBankDropDown.Text = "";
            }


            ShowLoadbanksInDropDown();
            extraInfoLabel.Text = "";
        }

        private void LoadBankDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            IndexOfSelected = GlobalData.LoadbankDataList.FindIndex(item => item == loadBankDropDown.SelectedItem as LoadbankModel);
            OutputResultsLabel.Text = "";
        }

        private void EditLoadbanksButton_Click(object sender, EventArgs e)
        {
            OutputResultsLabel.Text = "";
            LoadBankForm loadBankForm = new LoadBankForm();
            loadBankForm.newLoadbankFormState(false);
            loadBankForm.PassInLoadbankIndex(IndexOfSelected);
            loadBankForm.Show();
        }

        private void StringBuilderButton_Click(object sender, EventArgs e)
        {
            StringBuilderForm stringEditorForm = new StringBuilderForm();
            OutputResultsLabel.Text = "";
            stringEditorForm.PassInForm(this);
            stringEditorForm.Show();
            this.Hide();
        }

        private void DischargeMainForm_VisibleChanged(object sender, EventArgs e)
        {
            // this will get fired when the forms visibility changes

            // check to see if there is a string declared in the global data
            if (GlobalData.selectedBatteryString != null)
            {
                Console.WriteLine("String not Null");
                etvTextBox.Text = GlobalData.selectedBatteryString.GetStringETV().ToString();
                etvTextBox.Enabled = false;
                ClearStringDataButton.Enabled = true;
                LoadRateTextbox.Enabled = true;
                LoadRateTextbox.Text = "";
                loadRateLabel.Enabled = true;
                LoadRateSuffixLabel.Enabled = true;
            }
            else
            {
                // show the ETV textbox
                etvTextBox.Enabled = true;
                ClearStringDataButton.Enabled = false;
                LoadRateTextbox.Enabled = false;
                LoadRateTextbox.Text = "";
                loadRateLabel.Enabled = false;
                LoadRateSuffixLabel.Enabled = false;
            }
        }


        // just want to clear out the string data so user can input a voltage
        private void ClearStringDataButton_Click(object sender, EventArgs e)
        {
            OutputResultsLabel.Text = "";
            etvTextBox.Enabled = true;
            etvTextBox.Text = "0";
            ClearStringDataButton.Enabled = false;
            LoadRateTextbox.Enabled = false ;
            LoadRateTextbox.Text = "";
            loadRateLabel.Enabled = false;
            LoadRateSuffixLabel.Enabled = false;
            GlobalData.selectedBatteryString = null;
        }


        // do the calcs and pop to screen 
        private void showAchievableButton_Click(object sender, EventArgs e)
        {
            OutputResultsLabel.Text = " - - - - - ";
            if (GlobalData.selectedBatteryString != null)
            {
                string outputString = "not updated";
                // use the string data for more info
                // validate theres a voltage and loadbank selected
                float etv;
                LoadbankModel bankSelected = loadBankDropDown.SelectedItem as LoadbankModel;

                if (bankSelected != null && float.TryParse(etvTextBox.Text, out etv))
                {
                    
                    float loadRateRequired;
                    // SO - VALID BANK, VALID ETV AND CHECKING LOADRATE
                    if (float.TryParse(LoadRateTextbox.Text, out loadRateRequired) == false)
                    {
                        MessageBox.Show("Check required current is in numerical format ie 00.00");
           
                    }

                    // NOW CHECK TO SEE IF THE VOLTAGE TOLLERANCES ARE WITHIN LIMITS
                    else if (bankSelected.MaxInputVoltage < etv || bankSelected.MinInputVoltage > etv)
                    {
                        Console.WriteLine("VOLTAGE TOLLERANGE OUT");
                        if (bankSelected.MaxInputVoltage < etv)
                        {
                            outputString = "ETV Voltage Exceeds maximum voltage for " + bankSelected.Name + ".";
                        }
                         else if (bankSelected.MinInputVoltage > etv)
                        {
                            outputString = "ETV voltage is less than minimum voltage for " + bankSelected.Name + ".";
                        }
                    }
                    else
                    {
                        outputString = DoBatteryCalcs(loadRateRequired, bankSelected, etv);
                    }

                    
                        

                    // show the message
                    OutputResultsLabel.Text = outputString ;
                }
            }
            else
            {
                // validate theres a voltage and loadbank selected
                float etv;
                string outputString = "";

                LoadbankModel bankSelected = loadBankDropDown.SelectedItem as LoadbankModel;
                if (bankSelected != null && float.TryParse(etvTextBox.Text, out etv))
                {
                    if (etv == 0)
                    {
                        outputString = "No String Specified : \nETV Voltage cannot be 0!";
                    }
                    else
                    {
                        if (etv > bankSelected.MaxInputVoltage || etv < bankSelected.MinInputVoltage && etv > 0)
                        {
                            if (etv > bankSelected.MaxInputVoltage)
                            {
                                outputString = "ETV Voltage Exceeds maximum voltage for " + bankSelected.Name + ".";
                            }

                            if (etv < bankSelected.MinInputVoltage)
                            {
                                outputString = "ETV voltage is less than minimum voltage for " + bankSelected.Name + ".";
                            }
                        }
                        else
                        {
                            outputString = "No String Specified : \nmax current achievable @  ETV = " + Math.Round((AchievableCurrentAtETV(bankSelected, etv)), 2) + "A";
                        }
                    }
                }
                else
                {
                    outputString = "Invalid Entries Please double check!";
                }
                // show the message
                OutputResultsLabel.Text = outputString;
            }
        }

        float AchievableCurrentAtETV(LoadbankModel lb, float vETV)
        {

            
            Console.WriteLine("etv : " + vETV + " , resistance :" + lb.Resistance);
            return vETV / lb.Resistance;
        }

        private void etvTextBox_TextChanged(object sender, EventArgs e)
        {
            OutputResultsLabel.Text = "";
        }

        private void LoadRateTextbox_TextChanged(object sender, EventArgs e)
        {
            OutputResultsLabel.Text = "";
        }

        string DoBatteryCalcs(float _loadRate, LoadbankModel _lbank, float _etv)
        {
            string outputStringFromCalcs = "";
            float lowestVoltageNeeded = _loadRate * _lbank.Resistance;
            double minimumCellCount;
            float cellETV = (float)GlobalData.selectedBatteryString.GetBlockType().EtvVoltage;
            minimumCellCount = Math.Round(lowestVoltageNeeded / cellETV, 0, MidpointRounding.AwayFromZero);
            int stringCount = GlobalData.selectedBatteryString.GetStringCount();
            int cellsCanLose = stringCount - (int)minimumCellCount;
            string cellName = GlobalData.selectedBatteryString.GetBlockType().CellName;
            float currentAtETV = AchievableCurrentAtETV(_lbank, _etv);

            if (cellsCanLose > 0)
            {
                outputStringFromCalcs =
                   "Max current available of " + Math.Round(currentAtETV, 2) + "A available at ETV of " + _etv + "V .\n" +
                   "Lowest voltage required to get load of " + _loadRate + "A is " + Math.Round(lowestVoltageNeeded, 2) + "V\n\n" +
                   "Able to link out " + cellsCanLose + " blocks before load is unattainable.";
            }
            else
            {
                if (_loadRate > currentAtETV)
                {
                    outputStringFromCalcs =
                   "Max current available of " + Math.Round(currentAtETV, 2) + "A available at ETV of " + _etv + "V .\n" +
                   "Lowest voltage required to get load of " + _loadRate + "A is " + Math.Round(lowestVoltageNeeded, 2) + "V\n\n" +
                   "!! Required Load Rate is Larger than Achievable Current at ETV !!";
                }
                else
                {
                    outputStringFromCalcs =
                   "Max current available of " + Math.Round(currentAtETV, 2) + "A available at ETV of " + _etv + "V .\n" +
                   "Lowest voltage required to get load of " + outputStringFromCalcs + "A is " + Math.Round(lowestVoltageNeeded, 2) + "V\n\n";
                    if (lowestVoltageNeeded < _etv)
                        outputStringFromCalcs += " voltage required for this load is lower than ETV";
                    else
                        outputStringFromCalcs += "Can achieve current without linking any cells out.";
                }
            }

            return outputStringFromCalcs;
        }
    }
}

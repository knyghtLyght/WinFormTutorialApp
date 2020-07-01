using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    placeNumberTextBox.Text,
                    placeNameTextBox.Text,
                    prizeValueTextBox.Text,
                    prizePercentageTextbox.Text);

                GlobalConfig.Connection.CreatePirze(model);

                // Reset Form
                placeNumberTextBox.Text = "";
                placeNameTextBox.Text = "";
                prizeValueTextBox.Text = "0";
                prizePercentageTextbox.Text = "0";

            }
            else
            {
                MessageBox.Show("This form has invalid infos");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;

            if (!int.TryParse(placeNumberTextBox.Text, out placeNumber))
            {
                output = false;
            }

            if (placeNumber < 1)
            {
                output = false;
            }

            if (placeNameTextBox.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeValue = 0;
            double prizePercantage = 0;
            bool prizeAmountValid = decimal.TryParse(prizeValueTextBox.Text, out prizeValue);
            bool prizePercentageValid = double.TryParse(prizePercentageTextbox.Text, out prizePercantage);

            if (!prizeAmountValid || !prizePercentageValid)
            {
                output = false;
            }

            if (prizeValue <= 0 && prizePercantage <= 0)
            {
                output = false;
            }

            if (prizePercantage < 0 || prizePercantage > 100)
            {
                output = false;
            }

            return output;
        }
    }
}

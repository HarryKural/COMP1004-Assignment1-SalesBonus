using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharp_Mail_Order___SALES_BONUS
{
    public partial class SalesBonusForm : Form
    {
        public SalesBonusForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method validates that value entered
        /// cannot exceed 160 hours & is positive
        /// </summary>
        public void validHoursWorked(object sender, EventArgs e)
        {
            double hoursWorked = 0;

            // will work if it is a number
            if (Double.TryParse(HoursWorkedTextBox.Text, out hoursWorked))
            {
                if (hoursWorked < 0 || hoursWorked > 160)
                {
                    MessageBox.Show("Hours worked cannot exceed 160 hours.", "Warning: Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    HoursWorkedTextBox.Text = HoursWorkedTextBox.Text.Remove(HoursWorkedTextBox.Text.Length - 1);
                    HoursWorkedTextBox.SelectionStart = HoursWorkedTextBox.Text.Length;
                }
            }
            else
            {
                // error message if entered value is not a number
                if (HoursWorkedTextBox.Text != "")
                {
                    MessageBox.Show("You must enter any number.", "Error: Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // HoursWorkedTextBox.Text = String.Empty;
                    HoursWorkedTextBox.Text = HoursWorkedTextBox.Text.Remove(HoursWorkedTextBox.Text.Length - 1);
                    HoursWorkedTextBox.SelectionStart = HoursWorkedTextBox.Text.Length;
                }
            }
            
        }

        /// <summary>
        /// This method handle clicks on all the buttons
        /// </summary>
        public void buttonClickHandler(object sender, EventArgs e)
        {
            Button ClickHandler = sender as Button;

            switch (ClickHandler.Tag.ToString())
            {
                case "Calculate":
                    // variables
                    double hoursWorked = Double.Parse(HoursWorkedTextBox.Text);
                    double monthlySales = Double.Parse(TotalMonthlySalesTextBox.Text);
                    double percentageOfHoursWorked;
                    double bonusAmount;
                    double salesBonus;
                    
                    // calculating Percentage of hours worked during the bonus period
                    percentageOfHoursWorked = hoursWorked / 160;

                    // calculating Total Bonus Amount 2%
                    bonusAmount = monthlySales * 0.02;

                    // calculating Sales Bonus
                    salesBonus = percentageOfHoursWorked * bonusAmount;

                    // setting salesBonus text field to calculated value(string) 
                    SalesBonusTextBox.Text = salesBonus.ToString();
                    break;
                case "Print":
                    MessageBox.Show("Your information is in the process to print. Please Wait...", "Printing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Clear":
                    EmployeeNameTextBox.Text = "";
                    EmployeeIDTextBox.Text = "";
                    HoursWorkedTextBox.Text = "";
                    SalesBonusTextBox.Text = "";

                    // focusing cursor to the first field employee name
                    EmployeeNameTextBox.Focus();
                    break;
            }
        }
        
    }
}

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
    }
}

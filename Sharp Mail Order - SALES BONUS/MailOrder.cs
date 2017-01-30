/// <summary>
/// App name: Sharp Mail Order – SALES BONUS
/// Author's name: Harshit Sharma
/// Student Number#: 200333254
/// App Creation Date: Jan 16, 2017
/// Rapid Application Development - Assignment 1
/// App description: This application is used to calculate sales bonus of
/// an employee percentage of hours he or she worked during the bonus
/// period (a total of 160 hours)
/// </summary>

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
        /// cannot exceed 160 hours & is positive + values of monthly sales
        /// Using ternary operator in message box to switch language
        /// </summary>
        public void validValuesChecker(object sender, EventArgs e)
        {
            TextBox ValidValues = sender as TextBox;

            // fields cannot be empty so, it will not calculate anything
            if (HoursWorkedTextBox.Text != ""  || TotalMonthlySalesTextBox.Text != "")
            { 
                switch (ValidValues.Tag.ToString())
                {
                    case "hoursWorked":

                    double hoursWorked = 0;

                    /// will work if it is a number
                    /// removing 1 last value if it is > 160
                    /// cursor will move to the end value of text field
                    if (Double.TryParse(HoursWorkedTextBox.Text, out hoursWorked))
                    {
                        if (hoursWorked < 0 || hoursWorked > 160)
                        {
                            MessageBox.Show(EnglishRadioButton.Checked ? "Hours worked cannot exceed 160 hours." : "Les heures travaillées ne peuvent excéder 160 heures.", EnglishRadioButton.Checked ? "Warning: Invalid Value" : "Avertissement: valeur non valide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            HoursWorkedTextBox.Text = HoursWorkedTextBox.Text.Remove(HoursWorkedTextBox.Text.Length - 1);
                            HoursWorkedTextBox.SelectionStart = HoursWorkedTextBox.Text.Length;
                        }
                    }
                    else
                    {
                        // error message if entered value is not a number
                        if (HoursWorkedTextBox.Text != "")
                        {
                            MessageBox.Show(EnglishRadioButton.Checked ? "You must enter any number." : "Vous devez entrer n'importe quel numéro.", EnglishRadioButton.Checked ? "Error: Invalid Entry" : "Erreur: entrée non valide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // HoursWorkedTextBox.Text = String.Empty;
                            HoursWorkedTextBox.Text = HoursWorkedTextBox.Text.Remove(HoursWorkedTextBox.Text.Length - 1);
                            HoursWorkedTextBox.SelectionStart = HoursWorkedTextBox.Text.Length;
                        }
                    }
                    break;

                    case "monthlySales":

                    double monthlySales = 0;
                    string salesAmount = TotalMonthlySalesTextBox.Text.Replace("$", "");
                        
                    // error message if entered value is not a number
                    if (salesAmount != "" && !Double.TryParse(salesAmount, out monthlySales))
                    {
                        MessageBox.Show(EnglishRadioButton.Checked ? "You must enter any number." : "Vous devez entrer n'importe quel numéro.", EnglishRadioButton.Checked ? "Error: Invalid Entry" : "Erreur: entrée non valide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TotalMonthlySalesTextBox.Text = TotalMonthlySalesTextBox.Text.Remove(TotalMonthlySalesTextBox.Text.Length - 1);
                        TotalMonthlySalesTextBox.SelectionStart = TotalMonthlySalesTextBox.Text.Length;
                    }
                    break;
                }
            }
        }

        /// <summary>
        /// This method handle clicks on all the buttons
        /// </summary>
        public void buttonClickHandler(object sender, EventArgs e)
        {
            Button ClickHandler = sender as Button;

         // text fields cannot be empty
         if (HoursWorkedTextBox.Text != "")
         {
            switch (ClickHandler.Tag.ToString())
            {
                // calculation
                case "Calculate":
                    // variables to do calculations and parsing them to double
                    double hoursWorked = Double.Parse(HoursWorkedTextBox.Text);
                    double monthlySales = Double.Parse(TotalMonthlySalesTextBox.Text.Replace("$", ""));
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

                // will print if clicked print button
                case "Print":
                    MessageBox.Show(EnglishRadioButton.Checked ? "Your information is in the process to print. Please Wait..." : "Vos informations sont en cours d'impression. S'il vous plaît, attendez...", EnglishRadioButton.Checked ? "Printing" : "Impression", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                // clear text fields except monthly sales
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

        /// <summary>
        /// This method is used to change language from
        /// English to Français or vice versa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void languageChanger(object sender, EventArgs e)
        {
            if (FrançaisRadioButton.Checked == true)
            {
                LanguageGroupBox.Text = "La langue";
                EmployeeNameLabel.Text = "Le nom de l'employé";
                EmployeeIDLabel.Text = "Employé id:";
                HoursWorkedLabel.Text = "Heures travaillées:";
                TotalMonthlySalesLabel.Text = "Total des ventes mensuelles:";
                SalesBonusLabel.Text = "Bonus de vente:";
                CalculateButton.Text = "Calculer";
                PrintButton.Text = "Impression";
                ClearButton.Text = "Clair";
            }
            else
            {
                LanguageGroupBox.Text = "Language";
                EmployeeNameLabel.Text = "Employee's Name";
                EmployeeIDLabel.Text = "Employee ID:";
                HoursWorkedLabel.Text = "Hours Worked:";
                TotalMonthlySalesLabel.Text = "Total Monthly Sales:";
                SalesBonusLabel.Text = "Sales Bonus:";
                CalculateButton.Text = "Calculate";
                PrintButton.Text = "Print";
                ClearButton.Text = "Clear";
            }
        }
        
    }
}

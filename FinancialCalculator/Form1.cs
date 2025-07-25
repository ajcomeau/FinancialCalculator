using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace FinancialCalculator
{
    public partial class LoanCalc : Form
    {
        private MortgageAnalysis mortObject = new MortgageAnalysis();

        public LoanCalc()
        {
            InitializeComponent();
        }

        // --------------------------------------------------
        // MORTGAGE AND COMPOUND INTEREST CALCULATOR
        // A simple calcuator for determining loan details and
        // the results of a savings plan.
        // Developed as a classroom exercise in C# object-oriented
        // programming.
        // Andrew Comeau (ComeauSoftware.com) 
        // Last updated July 2025
        // --------------------------------------------------

        // --------------------------------------------------
        // MORTGAGE TAB FUNCTIONS
        // --------------------------------------------------

        private void btnGo_Click(object sender, EventArgs e)
        {
            // Update the fields with new values.
            UpdateFields();
        }

        private void UpdateFields()
        {
            try
            {
                // Populate the class with essential values from the form.
                mortObject.OriginalAmount = decimalValue(txtOriginalAmt.Text);
                // Allow for zero down payment. 
                mortObject.DownPaymentPercent = txtDownPmtPct.Value > 0 ? decimalValue(txtDownPmtPct.Value.ToString()) / 100 : 0;
                mortObject.LoanPeriodInMonths = (txtMonths.Text.Length > 0) ? int.Parse(txtMonths.Text) : 0;
                mortObject.InterestRate = txtInterest.Value > 0 ? ((decimal)txtInterest.Value / 100) : 0;

                // Re-populate the form fields with class functions.
                txtPrincipal.Text = mortObject.LoanPrincipal().ToString("C");
                txtPayment.Text = mortObject.MonthlyPayment().ToString("C");
                txtLoanTotal.Text = mortObject.TotalLoanAmount().ToString("C");
                txtTotalInterest.Text = mortObject.TotalInterest().ToString("C");
                txtPayOff.Text = mortObject.LoanCompletionDate().ToString("d");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }
        }

        private void txtbox_Validating(object sender, CancelEventArgs e)
        {
            double entryValue = 0;
            TextBox txt = sender as TextBox;

            if (txt == null) return;

            try
            {
                epLoanCalc.SetError(txt, "");
                // Reject anything but numeric values. 
                if (txt.Text.Length > 0 &&
                    !Double.TryParse(txt.Text, out entryValue))
                {
                    e.Cancel = true;
                    epLoanCalc.SetError(txt, "Please enter a numeric value.");
                }
                else
                {
                    // Reformat entry format.
                    if (txt.Name == "txtMonths")
                        txt.Text = entryValue.ToString("N0", CultureInfo.InvariantCulture);
                    else
                        txt.Text = entryValue.ToString("N", CultureInfo.InvariantCulture);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }
        }


        private void txtDownPmtPct_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                // If the original amount has been entered and the percent is more than 0
                // update the down payment dollar amount field.
                if (doubleValue(txtOriginalAmt.Text) > 0 && txtDownPmtPct.Value > 0)
                {
                    txtDownPmtAmt.Text = (doubleValue(txtOriginalAmt.Text) * (Double)(txtDownPmtPct.Value / 100)).ToString("N", CultureInfo.InvariantCulture);
                }
                // Update the fields with new values.
                UpdateFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }
        }

        private void txtInterest_ValueChanged(object sender, EventArgs e)
        {
            // Update the fields with new values.
            UpdateFields();
        }

        private decimal decimalValue(string TextString)
        {
            // Parse the numeric value of a textbox.
            // Put the code here to avoid repetition.
            decimal returnValue = 0;

            try
            {
                if (!decimal.TryParse(TextString, out returnValue))
                {
                    returnValue = 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            // Return the double.
            return returnValue;
        }

        private double doubleValue(string TextString)
        {
            // Parse the numeric value of a textbox.
            // Put the code here to avoid repetition.
            double returnValue = 0;

            try
            {
                if (!double.TryParse(TextString, out returnValue))
                {
                    returnValue = 0;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            // Return the double.
            return returnValue;
        }

        // --------------------------------------------------
        // COMPOUND INTEREST FUNCTIONS
        // --------------------------------------------------

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Get values from form
            decimal initDeposit = decimalValue(txtInitDeposit.Text);
            decimal intRate = (decimal)txtIntRate.Value / 100;
            decimal monthlyDep = decimalValue(txtMonthlyDep.Text);
            int timeInYears = int.Parse(txtYears.Text);
            int timesPerYear;

            if (radMonthly.Checked) timesPerYear = 12;
            else if (radQuarterly.Checked) timesPerYear = 4;
            else timesPerYear = 1;

            // Call the appropriate class method depending on the monthly deposits.
            if (monthlyDep > 0)
            {
                txtFinalAmt.Text = FinanceCalcs.CompoundingInterestWithDeposits(initDeposit, 
                    monthlyDep, intRate, timeInYears, timesPerYear).ToString("C");
            }
            else
            {
                txtFinalAmt.Text = FinanceCalcs.CompoundingInterest(initDeposit, intRate, 
                    timeInYears, timesPerYear).ToString("C");
            }
        }

        private void txtOriginalAmt_Leave(object sender, EventArgs e)
        {
            // Update the fields with new values.
            txtDownPmtPct.Value = 0;
            txtDownPmtAmt.Text = "0.00";
            UpdateFields();
        }

        private void txtDownPmtAmt_Leave(object sender, EventArgs e)
        {
            // Update the fields with new values.

            // If the original amount has been entered and the down payment is more than 0
            // update the down payment percent field.
            if (doubleValue(txtOriginalAmt.Text) > 0 && doubleValue(txtDownPmtAmt.Text) > 0)
            {
                txtDownPmtPct.Value = (Decimal)(doubleValue(txtDownPmtAmt.Text) / doubleValue(txtOriginalAmt.Text)) * 100;
            }

            UpdateFields();
        }

        private void txtMonths_Leave(object sender, EventArgs e)
        {
            // Update the fields with new values.
            UpdateFields();
        }


    }
}

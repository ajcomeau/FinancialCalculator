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
        // MORTGAGE FUNCTIONS
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
                mortObject.OriginalAmount = doubleValue(txtOriginalAmt.Text);
                // Allow for zero down payment. 
                mortObject.DownPaymentPercent = txtDownPmtPct.Value > 0 ? doubleValue(txtDownPmtPct.Value.ToString()) / 100 : 0;
                mortObject.LoanPeriodInMonths = (txtMonths.Text.Length > 0) ? int.Parse(txtMonths.Text) : 0;
                mortObject.InterestRate = txtInterest.Value > 0 ? ((Double)txtInterest.Value / 100) : 0;

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



        private void txtOriginalAmt_Validating(object sender, CancelEventArgs e)
        {
            double entryValue = 0;

            try
            {
                epLoanCalc.SetError(txtOriginalAmt, "");
                // Reject anything but numeric values. 
                if (txtOriginalAmt.Text.Length > 0 &&
                    !Double.TryParse(txtOriginalAmt.Text, out entryValue))
                {
                    e.Cancel = true;
                    epLoanCalc.SetError(txtOriginalAmt, "Please enter a numeric value.");
                }
                else
                {
                    // Reformat entry in 0,000.00 format.
                    txtOriginalAmt.Text = entryValue.ToString("N", CultureInfo.InvariantCulture);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }
        }


        private void txtMonths_Validating(object sender, CancelEventArgs e)
        {

            int entryValue = 0;

            try
            {
                epLoanCalc.SetError(txtMonths, "");
                // Reject anything but numeric values. 
                if (txtMonths.Text.Length > 0 &&
                    !int.TryParse(txtMonths.Text, out entryValue))
                {
                    e.Cancel = true;
                    epLoanCalc.SetError(txtMonths, "Please enter a numeric value.");
                }
                else
                {
                    // Reformat entry in 0,000.00 format.
                    txtMonths.Text = entryValue.ToString();
                }
            }
            catch(Exception ex)
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

        private void txtDownPmtAmt_Validating(object sender, CancelEventArgs e)
        {
            double entryValue = 0;

            try
            {
                epLoanCalc.SetError(txtDownPmtAmt, "");
                // Only accept numeric values.
                if (txtDownPmtAmt.Text.Length > 0 &&
                    !Double.TryParse(txtDownPmtAmt.Text, out entryValue))
                {
                    e.Cancel = true;
                    epLoanCalc.SetError(txtDownPmtAmt, "Please enter a numeric value.");
                }
                else
                {
                    // Format to 0,000.00 and upate the down payment percentage. 
                    txtDownPmtAmt.Text = entryValue.ToString("N", CultureInfo.InvariantCulture);
                    if (doubleValue(txtOriginalAmt.Text) > 0 && doubleValue(txtDownPmtAmt.Text) > 0)
                    {
                        txtDownPmtPct.Value = (Decimal)((doubleValue(txtDownPmtAmt.Text) / doubleValue(txtOriginalAmt.Text)) * 100);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }

        }

        private void txtOriginalAmt_TextChanged(object sender, EventArgs e)
        {
            // Update the fields with new values.
            UpdateFields();
        }


        private void txtMonths_TextChanged(object sender, EventArgs e)
        {
            // Update the fields with new values.
            UpdateFields();
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

        private void txtInitDeposit_Validating(object sender, CancelEventArgs e)
        {
            double entryValue = 0;

            try
            {
                epLoanCalc.SetError(txtInitDeposit, "");
                // Reject anything but numeric values. 
                if (txtInitDeposit.Text.Length > 0 &&
                    !double.TryParse(txtInitDeposit.Text, out entryValue))
                {
                    e.Cancel = true;
                    epLoanCalc.SetError(txtInitDeposit, "Please enter a numeric value.");
                }
                else
                {
                    // Reformat entry in 0,000.00 format.
                    txtInitDeposit.Text = entryValue.ToString("N", CultureInfo.InvariantCulture);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }
        }

        private void txtMonthlyDep_Validating(object sender, CancelEventArgs e)
        {
            double entryValue = 0;

            try
            {
                epLoanCalc.SetError(txtMonthlyDep, "");
                // Reject anything but numeric values. 
                if (txtMonthlyDep.Text.Length > 0 &&
                    !double.TryParse(txtMonthlyDep.Text, out entryValue))
                {
                    e.Cancel = true;
                    epLoanCalc.SetError(txtMonthlyDep, "Please enter a numeric value.");
                }
                else
                {
                    // Reformat entry in 0,000.00 format.
                    txtMonthlyDep.Text = entryValue.ToString("N", CultureInfo.InvariantCulture);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }
        }

        private void txtYears_Validating(object sender, CancelEventArgs e)
        {
            int entryValue = 0;

            try
            {
                epLoanCalc.SetError(txtYears, "");
                // Reject anything but numeric values. 
                if (txtYears.Text.Length > 0 &&
                    !int.TryParse(txtYears.Text, out entryValue))
                {
                    e.Cancel = true;
                    epLoanCalc.SetError(txtYears, "Please enter a numeric value.");
                }
                else
                {
                    // Reformat entry in 0,000.00 format.
                    txtYears.Text = entryValue.ToString("N", CultureInfo.InvariantCulture);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Get values from form
            double initDeposit = doubleValue(txtInitDeposit.Text);
            double intRate = (Double)txtIntRate.Value / 100;
            double monthlyDep = doubleValue(txtMonthlyDep.Text);
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
                txtFinalAmt.Text = FinanceCalcs.CompoundingInterest(initDeposit, 
                    intRate, timeInYears, timesPerYear).ToString("C");
            }
        }


    }
}

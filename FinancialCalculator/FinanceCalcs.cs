using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace FinancialCalculator
{
    class FinanceCalcs
    {
        public static decimal CompoundingInterest(decimal P, decimal r, int t, int n)
        {
            // Using the formula (1+r/n)(nt) from TheCalculatorSite.com
            // https://www.thecalculatorsite.com/articles/finance/compound-interest-formula.php?page=2
            // P = principal investment amount
            // r = annual interest rate(decimal)
            // n = number of times interest is compounded per year
            // t = time in years

            decimal returnResult = 0;

            try
            {
                returnResult = P * (decimal)Math.Pow((double)(1 + (r / n)), (n * t));
            }
            catch
            {
                returnResult = 0;
                throw;
            }

            return returnResult;
        }

        public static decimal CompoundingInterestWithDeposits(decimal P, decimal PMT, decimal r, int t, int n)
        {
            // Using the monthly contriutions formula from TheCalculatorSite.com
            // https://www.thecalculatorsite.com/articles/finance/compound-interest-formula.php?page=2
            // Tested against:
            // https://www.investor.gov/financial-tools-calculators/calculators/compound-interest-calculator
            // P = principal investment amount
            // PMT = monthly payment amount
            // r = annual interest rate(decimal)
            // n = number of times interest is compounded per year
            // t = time in years

            decimal pmtSeriesPlusInt = 0;
            decimal initAmtPlusInt = 0;
            //Formula assumes deposits are made as often as compounding. Monthly deposit amount 
            //must be converted to quarterly or yearly total if necessary.
            decimal deposit = (n == 12) ? PMT : (n == 4) ? PMT * 3 : (n == 1) ? (PMT * 12) : PMT;
            
            try
            {
                initAmtPlusInt = P * (decimal)Math.Pow((double)(1 + (r / n)), (n * t));
                pmtSeriesPlusInt = deposit * ((decimal)(Math.Pow((double)(1 + (r / n)), (n * t)) - 1) / (r / n));
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return initAmtPlusInt + pmtSeriesPlusInt;
        }


    }

    class MortgageAnalysis
    {
        decimal _OriginalAmt;
        decimal _downPaymentPct;
        int _loanInMonths;
        decimal _interestRate;
        DateTime _startDate;

        public decimal OriginalAmount
        {
            get { return _OriginalAmt; }
            set { _OriginalAmt = value; }
        }

        public decimal DownPaymentPercent
        {
            get { return _downPaymentPct; }
            set { if (value > 1) { _downPaymentPct = (value / 100); } else { _downPaymentPct = value; } }
        }

        public int LoanPeriodInMonths
        {
            get { return _loanInMonths; }
            set { _loanInMonths = value; }
        }

        public decimal InterestRate
        {
            get { return _interestRate; }
            set { if (value >= 1) { _interestRate = (value / 100); } else { _interestRate = value; } }
        }

        public DateTime LoanStartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        public MortgageAnalysis()
        {
            // Basic constructor defining start date of the loan as today.
            _OriginalAmt = 0;
            _downPaymentPct = 0;
            _loanInMonths = 0;
            _interestRate = 0;
            _startDate = DateTime.Today;
        }

        public MortgageAnalysis(decimal SalePrice, decimal DownPaymentPct, int LoanInMonths, decimal InterestRate, DateTime StartDate)
        {
            _OriginalAmt = SalePrice;
            _downPaymentPct = DownPaymentPct;
            _loanInMonths = LoanInMonths;
            _interestRate = (InterestRate / 100);
            _startDate = StartDate;
        }

        public MortgageAnalysis(decimal SalePrice, decimal DownPaymentPct, int LoanInMonths, decimal InterestRate)
        {
            _OriginalAmt = SalePrice;
            _downPaymentPct = DownPaymentPct;
            _loanInMonths = LoanInMonths;
            _interestRate = (InterestRate / 100);
            _startDate = DateTime.Today;
        }

        public decimal LoanPrincipal()
        {
            decimal returnValue;

            // Return loan principal as total of loan minus interest.

            try
            {
                if (_downPaymentPct == 0)
                    returnValue = _OriginalAmt;
                else if (_OriginalAmt > 0 && _downPaymentPct > 0)
                    returnValue = (_OriginalAmt - (_OriginalAmt * (decimal)_downPaymentPct));
                else
                    returnValue = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return returnValue;
        }

        public decimal TotalLoanAmount()
        {
            decimal returnValue;

            try
            {
                // Return total of loan as monthly payment multiplied by months.
                if (_loanInMonths > 0)
                    returnValue = (MonthlyPayment() * _loanInMonths);
                else
                    returnValue = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return returnValue;
        }

        public decimal TotalInterest()
        {
            decimal returnValue;

            // Return total interest as total of loan minus the principal.
            // Return 0 if the monthly payment has not been set.
            if (MonthlyPayment() > 0)
                returnValue = Math.Round((TotalLoanAmount() - LoanPrincipal()), 2);
            else
                returnValue = 0;

            return returnValue;
        }

        public decimal MonthlyPayment()
        {
            // Calculating the monthly mortgage payment from formula at:
            // https://www.wikihow.com/Calculate-Mortgage-Payments
            // P *((r * (Math.Pow(1 + r, n))) / (Math.Pow(1 + r, n)–1))

            decimal returnPayment = 0;
            decimal monthlyInterest = _interestRate / 12;
            decimal loanAmt = LoanPrincipal();

            try
            {
                if (loanAmt > 0 && _interestRate > 0)
                    returnPayment = loanAmt * ((monthlyInterest * (decimal)Math.Pow((double)(1 + monthlyInterest), _loanInMonths))
                        / ((decimal)Math.Pow((double)(double)(1 + monthlyInterest), _loanInMonths) - 1));
                else
                    returnPayment = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return returnPayment;
        }

        public DateTime LoanCompletionDate()
        {
            DateTime returnDate;

            try
            {
                // Return loan completion date.
                if (_loanInMonths > 0)
                    returnDate = _startDate.AddMonths(_loanInMonths);
                else
                    returnDate = DateTime.Today;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return returnDate;
        }
    }
}

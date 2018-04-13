using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCalculator
{
    class FinanceCalcs
    {
        public static double CompoundingInterest(double InitAmount, double Interest, int Years, int timesPerYear)
        {
            // Using the formula P(1+r/n)(nt) from TheCalculatorSite.com
            // https://www.thecalculatorsite.com/articles/finance/compound-interest-formula.php?page=2

            double returnResult = 0;

            try
            {
                returnResult = InitAmount * Math.Pow((1 + (Interest / timesPerYear)), (timesPerYear * Years));
            }
            catch
            {
                returnResult = 0;
                throw;
            }

            return returnResult;
        }

        public static double CompoundingInterestWithDeposits(double InitAmount, double MonthlyDeposit, double Interest, int Years, int timesPerYear)
        {
            // Using the formula P(1+r/n)(nt) + PMT × {[(1 + r/n)(nt) - 1] / (r/n)} from TheCalculatorSite.com
            // https://www.thecalculatorsite.com/articles/finance/compound-interest-formula.php?page=2

            double initAmount = 0;
            double pmtAmount = 0;
            double periodInterest = 0;
            double exponent = 0;

            try
            {
                initAmount = CompoundingInterest(InitAmount, Interest, Years, timesPerYear);
                periodInterest = Interest / timesPerYear;
                exponent = timesPerYear * Years;
                pmtAmount = MonthlyDeposit * (((Math.Pow((1 + periodInterest), exponent)) - 1) / periodInterest);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return initAmount + pmtAmount;
        }


    }

    class MortgageAnalysis
    {
        double _OriginalAmt;
        double _downPaymentPct;
        int _loanInMonths;
        double _interestRate;
        DateTime _startDate;

        public double OriginalAmount
        {
            get { return _OriginalAmt; }
            set { _OriginalAmt = value; }
        }

        public double DownPaymentPercent
        {
            get { return _downPaymentPct; }
            set { if (value > 1) { _downPaymentPct = (value / 100); } else { _downPaymentPct = value; } }
        }

        public int LoanPeriodInMonths
        {
            get { return _loanInMonths; }
            set { _loanInMonths = value; }
        }

        public double InterestRate
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

        public MortgageAnalysis(double SalePrice, double DownPaymentPct, int LoanInMonths, double InterestRate, DateTime StartDate)
        {
            _OriginalAmt = SalePrice;
            _downPaymentPct = DownPaymentPct;
            _loanInMonths = LoanInMonths;
            _interestRate = (InterestRate / 100);
            _startDate = StartDate;
        }

        public MortgageAnalysis(double SalePrice, double DownPaymentPct, int LoanInMonths, double InterestRate)
        {
            _OriginalAmt = SalePrice;
            _downPaymentPct = DownPaymentPct;
            _loanInMonths = LoanInMonths;
            _interestRate = (InterestRate / 100);
            _startDate = DateTime.Today;
        }

        public double LoanPrincipal()
        {
            double returnValue;

            // Return loan principal as total of loan minus interest.

            try
            {
                if (_downPaymentPct == 0)
                    returnValue = _OriginalAmt;
                else if (_OriginalAmt > 0 && _downPaymentPct > 0)
                    returnValue = (_OriginalAmt - (_OriginalAmt * (double)_downPaymentPct));
                else
                    returnValue = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return returnValue;
        }

        public double TotalLoanAmount()
        {
            double returnValue;

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

        public double TotalInterest()
        {
            double returnValue;

            // Return total interest as total of loan minus the principal.
            // Return 0 if the monthly payment has not been set.
            if (MonthlyPayment() > 0)
                returnValue = Math.Round((TotalLoanAmount() - LoanPrincipal()), 2);
            else
                returnValue = 0;

            return returnValue;
        }

        public double MonthlyPayment()
        {
            // Calculating the monthly mortgage payment from formula at:
            // https://www.wikihow.com/Calculate-Mortgage-Payments
            // P *((r * (Math.Pow(1 + r, n))) / (Math.Pow(1 + r, n)–1))

            double returnPayment = 0;
            double monthlyInterest = _interestRate / 12;
            double loanAmt = LoanPrincipal();

            try
            {
                if (loanAmt > 0 && _interestRate > 0)
                    returnPayment = loanAmt * ((monthlyInterest * Math.Pow((1 + monthlyInterest), _loanInMonths))
                        / (Math.Pow(1 + monthlyInterest, _loanInMonths) - 1));
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

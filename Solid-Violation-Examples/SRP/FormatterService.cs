using System.Globalization;

namespace Solid_Violation_Examples.SRP
{
    public class FormatterService
    {
        private const string DATE_FORMAT = "dd/MM/yyyy";
        private const string AMOUNT_FORMAT = "F2";

        public string FormatLine(Transaction transaction, int balance)
        {
            return $"{FormatDate(transaction.Date)} | {FormatNumber(transaction.Amount)} | {FormatNumber(balance)}";
        }

        private string FormatDate(DateOnly date)
        {
            return date.ToString(DATE_FORMAT, CultureInfo.InvariantCulture);
        }

        private string FormatNumber(int amount)
        {
            return amount.ToString(AMOUNT_FORMAT, CultureInfo.InvariantCulture);
        }
    }
}

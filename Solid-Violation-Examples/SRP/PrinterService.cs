namespace Solid_Violation_Examples.SRP
{
    public class PrinterService
    {
        private const string STATEMENT_HEADER = "DATE | AMOUNT | BALANCE";

        private readonly ConsolePrinter console;
        private readonly FormatterService formatter;

        public PrinterService(ConsolePrinter console, FormatterService formatter)
        {
            this.console = console;
            this.formatter = formatter;
        }

        public void Print(List<Transaction> transactions)
        {
            console.PrintLine(STATEMENT_HEADER);
            int balance = 0;

            foreach (var transaction in transactions.OrderByDescending(t => t.Date))
            {
                balance += transaction.Amount;
                string line = formatter.FormatLine(transaction, balance);
                console.PrintLine(line);
            }
        }
    }
}

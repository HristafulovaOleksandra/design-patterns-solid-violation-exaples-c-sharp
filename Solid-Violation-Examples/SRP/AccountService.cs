using System.Globalization;

namespace Solid_Violation_Examples.SRP
{
    public class AccountService
    {
        private const string STATEMENT_HEADER = "DATE | AMOUNT | BALANCE";
        private const string DATE_FORMAT = "dd/MM/yyyy";
        private const string AMOUNT_FORMAT = "F2";

        private readonly ITransactionRepository _transactionRepository;
        private readonly Clock _clock;
        private readonly ConsolePrinter _console;

        public AccountService(ITransactionRepository transactionRepository, Clock clock, ConsolePrinter console)
        {
            _transactionRepository = transactionRepository;
            _clock = clock;
            _console = console;
        }

        public void Deposit(int amount) => _transactionRepository.Add(TransactionWith(amount));
        public void Withdraw(int amount) => _transactionRepository.Add(TransactionWith(-amount));
        public void PrintStatement()
        {
            PrintHeader();
            PrintTransactions();
        }
        private void PrintHeader() => PrintLine(STATEMENT_HEADER);
        private void PrintTransactions()
        {
            List<Transaction> transactions = _transactionRepository.GetAll();
            int balance = 0;

            foreach(var transaction in transactions.OrderByDescending(t => t.Date))
            {
                balance += transaction.Amount;
                PrintLine(StatementLine(transaction, balance));
            }
        }
        private void PrintLine(string line) => Console.WriteLine(line);
        private string StatementLine(Transaction transaction, int balance) =>
            $"{FormatDate(transaction.Date)} | {FormatNumber(transaction.Amount)} | {FormatNumber(balance)}";
        private string FormatDate(DateOnly date) =>
            date.ToString(DATE_FORMAT, CultureInfo.InvariantCulture);
        private string FormatNumber(int amount) =>
            amount.ToString(AMOUNT_FORMAT, CultureInfo.InvariantCulture);

        private Transaction TransactionWith(int amount) => new Transaction(DateOnly.FromDateTime(DateTime.Today), amount);
    }
}

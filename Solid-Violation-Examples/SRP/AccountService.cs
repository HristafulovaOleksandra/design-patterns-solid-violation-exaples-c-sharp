namespace Solid_Violation_Examples.SRP
{
    public class AccountService
    {
        private readonly ITransactionRepository transactionRepository;
        private readonly Clock clock;
        private readonly PrinterService printerService;

        public AccountService(ITransactionRepository transactionRepository, Clock clock, PrinterService printerService)
        {
            this.transactionRepository = transactionRepository;
            this.clock = clock;
            this.printerService = printerService;
        }

        public void Deposit(int amount)
        {
            transactionRepository.Add(new Transaction(clock.Today, amount));
        }

        public void Withdraw(int amount)
        {
            transactionRepository.Add(new Transaction(clock.Today, -amount));
        }

        public void PrintStatement()
        {
            var transactions = transactionRepository.GetAll();
            printerService.Print(transactions);
        }
    }
}

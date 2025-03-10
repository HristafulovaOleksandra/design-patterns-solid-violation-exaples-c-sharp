namespace Solid_Violation_Examples.SRP
{
    public interface ITransactionRepository
    {
        void Add(Transaction transaction);
        List<Transaction> GetAll();
    }
}

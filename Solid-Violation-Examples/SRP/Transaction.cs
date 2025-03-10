namespace Solid_Violation_Examples.SRP
{
    public class Transaction
    {
        public DateOnly Date {  get; private set; }
        public int Amount { get; private set; }
        public Transaction(DateOnly date, int amount)
        {
            Date = date;
            Amount = amount;
        }
    }
}

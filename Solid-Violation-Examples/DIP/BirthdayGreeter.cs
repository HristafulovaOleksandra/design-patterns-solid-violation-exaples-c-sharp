namespace Solid_Violation_Examples.DIP
{
    public class BirthdayGreeter
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly Clock _clock;

        public BirthdayGreeter(IEmployeeRepository employeeRepository, Clock clock)
        {
            _employeeRepository = employeeRepository;
            _clock = clock;
        }
        public void SendGreetings()
        {
            DateOnly today = _clock.MonthDay();
            _employeeRepository.FindEmployeesBornOn(today)
                .Select(EmailFor)
                .ToList()
                .ForEach(email => new EmailSender().Send(email));
        }
        private Email EmailFor(Employee employee)
        {
            string message = $"Happy birthday, dear {employee.FirstName}";
            return new Email(employee.Email, "Happy birthday!", message);
        }
    }
}

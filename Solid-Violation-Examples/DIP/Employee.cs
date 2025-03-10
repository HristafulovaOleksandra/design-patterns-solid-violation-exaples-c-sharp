namespace Solid_Violation_Examples.DIP
{
    public class Employee
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateOnly DateOfBirth { get; private set; }
        public string Email { get; private set; }
        public Employee(string firstName, string lastName, DateOnly dateOfBirth, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Email = email;
        }
    }
}

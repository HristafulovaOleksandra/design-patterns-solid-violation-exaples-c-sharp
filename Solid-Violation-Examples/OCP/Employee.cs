namespace Solid_Violation_Examples.OCP
{
    public class Employee
    {
        private int _salary;
        private int _bonus;
        private EmployeeType _type;
        public Employee(int salary, int bonus, EmployeeType type)
        {
            _salary = salary;
            _bonus = bonus;
            _type = type;
        }
        public int PayAmount()
        {
            return _type switch
            {
                EmployeeType.ENGINEER => _salary,
                EmployeeType.MANAGER => _salary + _bonus,
                _ => 0
            };
        }
    }
}

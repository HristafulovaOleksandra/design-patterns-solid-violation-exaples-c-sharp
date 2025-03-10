namespace Solid_Violation_Examples.DIP
{
    public interface IEmployeeRepository
    {
        List<Employee> FindEmployeesBornOn(DateOnly monthDay);   
    }
}

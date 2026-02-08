using System;
class Program
{
    static void Main(string[] args)
    {
        Employee emp1 = new Employee { name = "иван", baseSalary = 100000 };
        Employee emp2 = new Employee { name = "мария", baseSalary = 80000 };
        Employee emp3 = new Employee { name = "петр", baseSalary = 50000 };
        ISalaryCalculator permanentCalc = new PermanentEmployeeSalaryCalculator();
        ISalaryCalculator contractCalc = new ContractEmployeeSalaryCalculator();
        ISalaryCalculator internCalc = new InternSalaryCalculator();
        Console.WriteLine($"{emp1.name}: {permanentCalc.CalculateSalary(emp1)}");
        Console.WriteLine($"{emp2.name}: {contractCalc.CalculateSalary(emp2)}");
        Console.WriteLine($"{emp3.name}: {internCalc.CalculateSalary(emp3)}");
    }
}
public class Employee
{
    public string name { get; set; } = string.Empty;
    public double baseSalary { get; set; }
}
public interface ISalaryCalculator
{
    double CalculateSalary(Employee employee);
}
public class PermanentEmployeeSalaryCalculator : ISalaryCalculator
{
    public double CalculateSalary(Employee employee)
    {
        return employee.baseSalary * 1.2;
    }
}
public class ContractEmployeeSalaryCalculator : ISalaryCalculator
{
    public double CalculateSalary(Employee employee)
    {
        return employee.baseSalary * 1.1;
    }
}
public class InternSalaryCalculator : ISalaryCalculator
{
    public double CalculateSalary(Employee employee)
    {
        return employee.baseSalary * 0.8;
    }
}
public class FreelancerSalaryCalculator : ISalaryCalculator
{
    public double CalculateSalary(Employee employee)
    {
        return employee.baseSalary * 1.0;
    }
}
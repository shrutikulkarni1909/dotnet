namespace EmployeeManagement.Models;

public class SalesEmployee : Employee
{
    private double commission;

    public SalesEmployee() : base(20000, 5000, 3000){
        commission=4000;
    }

    public new double CalculateSalary(){
        return BasicSalary + HRA + DA + commission;
    }

    public override double CalculateBonus(){
        return BasicSalary * 0.10;
    }
}

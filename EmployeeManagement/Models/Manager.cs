namespace EmployeeManagement.Models;

public class Manager : Employee{
    private double incentive;

    public Manager() : base(){
        incentive=0;
    }

        public Manager(double basicSal, double hra, double da, double incentive)
        : base(basicSal, hra, da)
    {
        this.incentive = incentive;
    }
    public double CalculateIncentives()
    {
        return incentive;
    }
    public override double CalculateSalary()
    {
        return base.CalculateSalary() + incentive;
    }
    public override double CalculateBonus()
    {
        return BasicSalary * 0.20;
    }
     public override string ToString()
    {
        return base.ToString() + $", Incentive: {incentive}";
    }
}
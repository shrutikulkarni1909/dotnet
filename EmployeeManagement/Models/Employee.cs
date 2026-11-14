namespace EmployeeManagement.Models;

public abstract class Employee{
    private double basicSal;
    private double hra;
    private double da;

    public double BasicSalary => basicSal;
    public double HRA => hra;
    public double DA => da;

    public Employee()
    {
        basicSal = 0;
        hra = 0;
        da = 0;
    }



    public Employee(double basicSal, double hra, double da){
        this.basicSal=basicSal;
        this.hra=hra;
        this.da=da;
    }

    public virtual double CalculateSalary(){
        return basicSal+hra+da;
    }

    public abstract double CalculateBonus();

    public override string ToString(){
        return $"Basic Salary: {basicSal}, HRA: {hra}, DA: {da}";
    }
}
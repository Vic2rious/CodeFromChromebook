using System;

public class Employee
{
    protected int Hours { get; } = 40;
    protected double Salary { get; set; } = 40000;
    protected int Vacation { get; set; } = 10;

    public virtual int GetHours()
    {
        return Hours;
    }

    public virtual double GetSalary()
    {
        return Salary;
    }

    public virtual int GetVacation()
    {
        return Vacation;
    }

    public virtual string GetForm()
    {
        return "yellow";
    }

    public virtual string JobSkill()
    {
        return "Just an average employee";
    }
}

public class Lawyer : Employee
{
    public Lawyer()
    {
        Vacation = 15;
        Salary = 60000;
    }

    public override string JobSkill()
    {
        return "I can handle Lawsuits";
    }
    public override string GetForm()
    {
      return "blue";
    }
}

public class Secretary : Employee
{
    public override string JobSkill()
    {
        return "I can dictate a message";
    }
}

public class LegalSecretary : Secretary
{
    private string Skill { get; } = "Files legal paperwork";
    private double Bonus { get; } = 5000;

    public override double GetSalary()
    {
        return base.GetSalary() + Bonus;
    }

    public override string JobSkill()
    {
        return base.JobSkill() + "\n" + Skill;
    }
}

public static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Employee: ");
        Employee jim = new Employee();
        Console.WriteLine("Work Hours:\t" + jim.GetHours());
        Console.WriteLine("Salary:\t\t" + jim.GetSalary());
        Console.WriteLine("Vacation:\t" + jim.GetVacation());
        Console.WriteLine("Form Type\t" + jim.GetForm());
        Console.WriteLine(jim.JobSkill() + "\n");

        Console.WriteLine("Secretary: ");
        Employee bob = new Secretary();
        Console.WriteLine("Work Hours:\t" + bob.GetHours());
        Console.WriteLine("Salary:\t\t" + bob.GetSalary());
        Console.WriteLine("Vacation:\t" + bob.GetVacation());
        Console.WriteLine("Form Type\t" + bob.GetForm());
        Console.WriteLine(bob.JobSkill() + "\n");

        Console.WriteLine("Lawyer: ");
        Employee ace = new Lawyer();
        Console.WriteLine("Work Hours:\t" + ace.GetHours());
        Console.WriteLine("Salary:\t\t" + ace.GetSalary());
        Console.WriteLine("Vacation:\t" + ace.GetVacation());
        Console.WriteLine("Form Type\t" + ace.GetForm());
        Console.WriteLine(ace.JobSkill() + "\n");

        Console.WriteLine("Legal Secretary: ");
        Employee suzie = new LegalSecretary();
        Console.WriteLine("Work Hours:\t" + suzie.GetHours());
        Console.WriteLine("Salary:\t\t" + suzie.GetSalary());
        Console.WriteLine("Vacation:\t" + suzie.GetVacation());
        Console.WriteLine("Form Type\t" + suzie.GetForm());
        Console.WriteLine(suzie.JobSkill() + "\n");
    }
}

1)
using System;
using System.Collections.Generic;

namespace Lern_pract_2._1


public class Worker
{
    public string Name;
    public string Surname;
    public double Rate;
    public int Days;

    public double GetSalary()
    {
        return Rate * Days;
    }
}

public class Program
{
    public static void Main()
    {
        Worker worker = new Worker();
        worker.Name = "Phillip";
        worker.Surname = "Gallager";
        worker.Rate = 1375;
        worker.Days = 15;

        double salary = worker.GetSalary();
        Console.WriteLine($"Зарплата работника {worker.Name} {worker.Surname}: {salary}");
    }
}

2)
using System;
using System.Collections.Generic;

    
public class Worker
{
    private string name;
    private string surname;
    private double rate;
    private int days;

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void SetSurname(string surname)
    {
        this.surname = surname;
    }

    public string GetSurname()
    {
        return surname;
    }

    public string SetRate(double rate)
    {
        this.rate = rate;
    }

    public double GetRate()
    {
        return rate;
    }

    public int SetDays(int days)
    {
        this.days = days;
    }

    public int GetDays()
    {
        return days;
    }

    public double GetSalary()
    {
        return rate * days;
    }
}

public class Program
{
    public static void Main()
    {
        Worker worker = new Worker();
        worker.SetName("Phillip");
        worker.SetSurname("Gallager");
        worker.SetRate(1375);
        worker.SetDays(15);

        double salary = worker.GetSalary();
        Console.WriteLine($"Зарплата работника {worker.GetName()} {worker.GetSurname()}: {salary}");
    }
}

3)
using System;

public class Calculation
{
    private string calculationLine;

    public void SetCalculationLine(string line)
    {
        calculationLine = line;
    }

    public void SetLastSymbolCalculationLine(char symbol)
    {
        calculationLine += symbol;
    }

    public string GetCalculationLine()
    {
        return calculationLine;
    }

    public char GetLastSymbol()
    {
        return calculationLine[calculationLine.Length - 1];
    }

    public void DeleteLastSymbol()
    {
        calculationLine = calculationLine.Remove(calculationLine.Length - 1);
    }
}

public class Program
{
    public static void Main()
    {
        Calculation calculation = new Calculation();
        calculation.SetCalculationLine("2 + 2");
        Console.WriteLine($"Строка вычисления: {calculation.GetCalculationLine()}");

        calculation.SetLastSymbolCalculationLine('=');
        Console.WriteLine($"Строка вычисления: {calculation.GetCalculationLine()}");

        char lastSymbol = calculation.GetLastSymbol();
        Console.WriteLine($"Последний символ: {lastSymbol}");

        calculation.DeleteLastSymbol();
        Console.WriteLine($"Строка вычисления: {calculation.GetCalculationLine()}");
    }
}



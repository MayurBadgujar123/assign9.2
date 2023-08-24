namespace  System;

internal  class Employee
{
    private string name;
    private int empNo;
    private decimal basic;
    private short deptNo;

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be blank or empty.");
            name = value;
        }
    }
    public int EmpNo
    {
        get { return empNo; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("EmpNo must be greater than 0.");
            empNo = value;
        }
    }
    public decimal Basic
    {
        get { return basic; }
        set
        {
            // Set the range for the Basic property as per your requirement
            if (value < 0 || value > 10000)
                throw new ArgumentException("Basic must be between the specified range.");
            basic = value;
        }
    }
    public short DeptNo
    {
        get { return deptNo; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("DeptNo must be greater than 0.");
            deptNo = value;
        }
    }

    public Employee(int empNo, string name, decimal basic, short deptNo)
    {
        EmpNo = empNo;
        Name = name;
        Basic = basic;
        DeptNo = deptNo;
    }

    public Employee(int empNo, string name, decimal basic)
        : this(empNo, name, basic, 0)
    {
    }

    public Employee(int empNo, string name)
        : this(empNo, name, 0, 0)
    {
    }

    public Employee(int empNo)
        : this(empNo, "", 0, 0)
    {
    }

    public Employee()
        : this(0, "", 0, 0)
    {
    }

    public decimal GetNetSalary()
    {
        // Implement your net salary calculation logic here
        // For example:
        decimal netSalary = Basic * 0.8M; // 80% of the basic salary
        return netSalary;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee o1 = new Employee(1, "Amol", 123465, 10);
        Employee o2 = new Employee(1, "Amol", 123465);
        Employee o3 = new Employee(1, "Amol");
        Employee o4 = new Employee(1);
        Employee o5 = new Employee();

        Console.WriteLine("o1 EmpNo: " + o1.EmpNo);
        Console.WriteLine("o2 EmpNo: " + o2.EmpNo);
        Console.WriteLine("o3 EmpNo: " + o3.EmpNo);
        Console.WriteLine("o4 EmpNo: " + o4.EmpNo);
        Console.WriteLine("o5 EmpNo: " + o5.EmpNo);
    }
}
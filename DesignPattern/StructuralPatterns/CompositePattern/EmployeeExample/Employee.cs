namespace DesignPattern.StructuralPatterns.CompositePattern.EmployeeExample;
// 结构型模式

/// <summary>
/// 组合模式
/// 员工类
/// </summary>
public class Employee
{
    public string Name { get; }         // 姓名
    public string Department { get; }   // 部门
    public int Salary { get; }          // 工资
    public ISet<Employee> Subordinates; // 下属

    public Employee(string name, string department, int salary)
    {
        Name = name;
        Department = department;
        Salary = salary;
        Subordinates = new HashSet<Employee>();
    }

    public void AddSubordinate(Employee e)
    {
        Subordinates.Add(e);
    }

    public void RemoveSubordinate(Employee e)
    {
        Subordinates.Remove(e);
    }

    public override string ToString()
    {
        return $"Employee[Name: {Name}, Department: {Department}, Salary: {Salary}]";
    }
}
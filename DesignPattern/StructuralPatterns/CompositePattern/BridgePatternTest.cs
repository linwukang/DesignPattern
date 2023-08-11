using DesignPattern.StructuralPatterns.CompositePattern.EmployeeExample;
using NUnit.Framework;

namespace DesignPattern.StructuralPatterns.CompositePattern;
// 结构型模式

/// <summary>
/// 组合模式
/// 测试类
/// </summary>
[TestFixture]
public class BridgePatternTest
{
    [Test]
    public void TestEmployeeExample()
    {
        Employee CEO = new Employee("John", "CEO", 30000);

        Employee headSales = new Employee("Robert", "Head Sales", 20000);

        Employee headMarketing = new Employee("Michel", "Head Marketing", 20000);

        Employee clerk1 = new Employee("Laura", "Marketing", 10000);
        Employee clerk2 = new Employee("Bob", "Marketing", 10000);

        Employee salesExecutive1 = new Employee("Richard", "Sales", 10000);
        Employee salesExecutive2 = new Employee("Rob", "Sales", 10000);

        CEO.AddSubordinate(headSales);
        CEO.AddSubordinate(headMarketing);

        headSales.AddSubordinate(salesExecutive1);
        headSales.AddSubordinate(salesExecutive2);

        headMarketing.AddSubordinate(clerk1);
        headMarketing.AddSubordinate(clerk2);
        Console.WriteLine(CEO);
        foreach (var headEmployee in CEO.Subordinates)
        {
            Console.WriteLine(headEmployee);
            foreach (var employee in headEmployee.Subordinates)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
using DesignPattern.StructuralPatterns.FilterPattern.PersonExample;
using NUnit.Framework;

namespace DesignPattern.StructuralPatterns.FilterPattern;
// 结构型模式

/// <summary>
/// 过滤器模式测试类
/// </summary>
[TestFixture]
public class FilterPatternTest
{
    [Test]
    public void TestPersonExample()
    {
        IList<Person> persons = new List<Person>
        {
            new("Robert", "Male", "Single"),
            new("John", "Male", "Married"),
            new("Laura", "Female", "Married"),
            new("Diana", "Female", "Single"),
            new("Mike", "Male", "Single"),
            new("Bobby", "Male", "Single"),
        };

        IFilter male = new MaleFilter();
        IFilter female = new FemaleFilter();
        IFilter single = new SingleFilter();
        IFilter singleMale = new AndFilter(single, male);
        IFilter singleOrFemale = new OrFilter(single, female);

        Console.WriteLine("Males: ");
        foreach (var person in male.MeetFilter(persons))
        {
            Console.WriteLine(person);
        }

        Console.WriteLine("\nFemales: ");
        foreach (var person in female.MeetFilter(persons))
        {
            Console.WriteLine(person);
        }

        Console.WriteLine("\nSingle Males: ");
        foreach (var person in singleMale.MeetFilter(persons))
        {
            Console.WriteLine(person);
        }

        Console.WriteLine("\nSingle Or Females: ");
        foreach (var person in singleOrFemale.MeetFilter(persons))
        {
            Console.WriteLine(person);
        }
    }
}
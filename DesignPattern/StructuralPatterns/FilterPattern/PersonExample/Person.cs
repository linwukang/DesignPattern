namespace DesignPattern.StructuralPatterns.FilterPattern.PersonExample;
// 结构型模式

/// <summary>
/// 过滤器模式
/// 人类
/// </summary>
public class Person
{
    public Person(string name, string gender, string maritalStatus)
    {
        Name = name;
        Gender = gender;
        MaritalStatus = maritalStatus;
    }

    public string Name { get; private set; }
    public string Gender { get; private set; }
    public string MaritalStatus { get; private set; }

    public override string ToString()
    {
        return $"Person[Name={Name}, Gender={Gender}, MaritalStatus={MaritalStatus}]";
    }
}
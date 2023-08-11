namespace DesignPattern.StructuralPatterns.AdapterPattern.AnimalExample;
// 结构型模式

/// <summary>
/// 适配器模式
/// 学生类
/// </summary>
public class Student : IPerson
{
    public Student(string name)
    {
        Name = name;
    }

    public string Name { get; init; }

    public void Speak()
    {
        Console.WriteLine($"我是学生，我的名字叫{Name}");
    }
}
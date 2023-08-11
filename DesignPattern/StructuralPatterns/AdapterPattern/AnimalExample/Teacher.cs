namespace DesignPattern.StructuralPatterns.AdapterPattern.AnimalExample;
// 结构型模式

/// <summary>
/// 适配器模式
/// 老师类
/// </summary>
public class Teacher : IPerson
{
    public Teacher(string name)
    {
        Name = name;
    }

    public string Name { get; init; }
    public void Speak()
    {
        Console.WriteLine($"我是老师，我的名字叫{Name}");
    }
}
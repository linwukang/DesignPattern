namespace DesignPattern.StructuralPatterns.AdapterPattern.AnimalExample;
// 结构型模式

/// <summary>
/// 适配器模式
/// 狗类
/// </summary>
public class Dog : IAnimal
{
    public void Sound()
    {
        Console.WriteLine("汪!汪!");
    }
}
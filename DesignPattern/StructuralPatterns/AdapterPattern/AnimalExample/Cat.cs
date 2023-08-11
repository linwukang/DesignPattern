namespace DesignPattern.StructuralPatterns.AdapterPattern.AnimalExample;
// 结构型模式

/// <summary>
/// 适配器模式
/// 猫类
/// </summary>
public class Cat : IAnimal
{
    public void Sound()
    {
        Console.WriteLine("喵~喵~");
    }
}
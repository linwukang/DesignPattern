namespace DesignPattern.CreationalPatterns.AbstractFactoryPattern.ShapeColorExample;
// 创建型模式

/// <summary>
/// 抽象工厂模式
/// 蓝色类
/// </summary>
public class Blue : IColor
{
    public void Fill()
    {
        Console.WriteLine("Inside Blue.Fill() method.");
    }
}
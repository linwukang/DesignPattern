namespace DesignPattern.CreationalPatterns.AbstractFactoryPattern.ShapeColorExample;
// 创建型模式

/// <summary>
/// 抽象工厂模式
/// 红色类
/// </summary>
public class Red : IColor
{
    public void Fill()
    {
        Console.WriteLine("Inside Red.Fill() method.");
    }
}
namespace DesignPattern.CreationalPatterns.AbstractFactoryPattern.ShapeColorExample;
// 创建型模式

/// <summary>
/// 抽象工厂模式
/// 绿色类
/// </summary>
public class Green : IColor
{
    public void Fill()
    {
        Console.WriteLine("Inside Green.Fill() method.");
    }
}
namespace DesignPattern.CreationalPatterns.AbstractFactoryPattern.ShapeColorExample;
// 创建型模式

/// <summary>
/// 抽象工厂模式
/// 矩形类
/// </summary>
public class Rectangle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Inside Rectangle.Draw() method.");
    }
}
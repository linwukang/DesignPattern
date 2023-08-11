namespace DesignPattern.CreationalPatterns.AbstractFactoryPattern.ShapeColorExample;
// 创建型模式

/// <summary>
/// 抽象工厂模式
/// 正方形类
/// </summary>
public class Square : IShape
{
    public void Draw()
    {
        Console.WriteLine("Inside Square.Draw() method.");
    }
}
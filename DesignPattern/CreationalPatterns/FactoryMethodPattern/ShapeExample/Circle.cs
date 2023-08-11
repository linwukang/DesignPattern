namespace DesignPattern.CreationalPatterns.FactoryMethodPattern.ShapeExample;
// 创建型模式

/// <summary>
/// 工厂方法模式
/// 圆形类
/// </summary>
public class Circle : IShape
{
    public void Draw()
    {
        Console.WriteLine("Inside Circle.Draw() method.");
    }
}
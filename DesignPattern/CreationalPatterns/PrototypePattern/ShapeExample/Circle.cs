namespace DesignPattern.CreationalPatterns.PrototypePattern.ShapeExample;
// 创建型模式

/// <summary>
/// 原型模式
/// 圆形类
/// </summary>
public class Circle : Shape
{
    public Circle()
    {
        Type = "Circle";
    }

    public override void Draw()
    {
        Console.WriteLine("Inside Circle.Draw() method.");
    }
}
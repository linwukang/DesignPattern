namespace DesignPattern.CreationalPatterns.PrototypePattern.ShapeExample;
// 创建型模式

/// <summary>
/// 原型模式
/// 矩形类
/// </summary>
public class Rectangle : Shape
{
    public Rectangle()
    {
        Type = "Rectangle";
    }

    public override void Draw()
    {
        Console.WriteLine("Inside Rectangle.Draw() method.");
    }
}
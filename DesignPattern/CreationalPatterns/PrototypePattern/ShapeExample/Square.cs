namespace DesignPattern.CreationalPatterns.PrototypePattern.ShapeExample;
// 创建型模式

/// <summary>
/// 原型模式
/// 正方形类
/// </summary>
public class Square : Shape
{
    public Square()
    {
        Type = "Square";
    }

    public override void Draw()
    {
        Console.WriteLine("Inside Square.Draw() method.");
    }
}
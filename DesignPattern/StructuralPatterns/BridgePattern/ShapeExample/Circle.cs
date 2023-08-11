namespace DesignPattern.StructuralPatterns.BridgePattern.ShapeExample;
// 结构型模式

/// <summary>
/// 桥接模式
/// 圆形类
/// </summary>
public class Circle : Shape
{
    public Circle(IColor color) : base(color)
    {
    }

    public override void Draw()
    {
        Console.WriteLine("Drawing a circle.");
        Color.Fill();
    }
}
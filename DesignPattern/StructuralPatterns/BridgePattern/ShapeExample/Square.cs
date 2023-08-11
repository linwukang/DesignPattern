namespace DesignPattern.StructuralPatterns.BridgePattern.ShapeExample;
// 结构型模式

/// <summary>
/// 桥接模式
/// 正方形类
/// </summary>
public class Square : Shape
{
    public Square(IColor color) : base(color)
    {
    }

    public override void Draw()
    {
        Console.WriteLine("Drawing a square.");
        Color.Fill();
    }
}
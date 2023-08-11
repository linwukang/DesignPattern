namespace DesignPattern.StructuralPatterns.BridgePattern.ShapeExample;
// 结构型模式

/// <summary>
/// 桥接模式
/// 形状类
/// </summary>
public abstract class Shape
{
    protected IColor Color;

    protected Shape(IColor color)
    {
        Color = color;
    }

    public abstract void Draw();
}
namespace DesignPattern.CreationalPatterns.FactoryMethodPattern.ShapeExample;
// 结构型模式

/// <summary>
/// 装饰器模式
/// 红色边框形状装饰器类
/// </summary>
public class RedBorderShapeDecorator : ShapeDecorator
{
    public RedBorderShapeDecorator(IShape decoratedShape) : base(decoratedShape)
    {
    }

    public override void Draw()
    {
        DecoratedShape.Draw();
        SetRedBorder(DecoratedShape);
    }

    private void SetRedBorder(IShape decoratedShape)
    {
        Console.WriteLine("Border Color: Red");
    }
}
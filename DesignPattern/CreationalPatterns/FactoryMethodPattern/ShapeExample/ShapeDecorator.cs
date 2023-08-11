namespace DesignPattern.CreationalPatterns.FactoryMethodPattern.ShapeExample;
// 结构型模式

/// <summary>
/// 装饰器模式
/// 形状类型的装饰器
/// </summary>
public abstract class ShapeDecorator : IShape
{
    protected readonly IShape DecoratedShape;

    protected ShapeDecorator(IShape decoratedShape)
    {
        DecoratedShape = decoratedShape;
    }

    public virtual void Draw()
    {
        DecoratedShape.Draw();
    }
}
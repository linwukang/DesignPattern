namespace DesignPattern.CreationalPatterns.FactoryMethodPattern.ShapeExample;
// 创建型模式

/// <summary>
/// 工厂方法模式
/// Shape 的工厂类
/// </summary>
public class ShapeFactory
{
    public IShape? GetShape(string shapeType)
    {
        return shapeType switch
        {
            "RECTANGLE" => new Rectangle(),
            "SQUARE" => new Square(),
            "CIRCLE" => new Circle(),
            _ => null
        };
    }
}
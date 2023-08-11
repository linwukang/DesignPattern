using System.Collections;

namespace DesignPattern.CreationalPatterns.PrototypePattern.ShapeExample;
// 创建型模式

/// <summary>
/// 原型模式
/// 
/// </summary>
public class ShapeCache
{
    private static readonly IDictionary<string, Shape> ShapeDictionary;

    /// <summary>
    /// 从数据库中获取形状
    /// </summary>
    static ShapeCache()
    {
        ShapeDictionary = new Dictionary<string, Shape>
        {
            ["1"] = new Circle { Id = "1" },
            ["2"] = new Square { Id = "2" },
            ["3"] = new Rectangle { Id = "3" },
        };
    }

    public static Shape? GetShape(String shapeId)
    {
        var cachedShape = ShapeDictionary[shapeId];
        return cachedShape.Clone() as Shape;
    }
}
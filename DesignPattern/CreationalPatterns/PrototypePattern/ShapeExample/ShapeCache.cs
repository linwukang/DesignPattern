using System.Collections;

namespace DesignPattern.CreationalPatterns.PrototypePattern.ShapeExample;
// 创建型模式

/// <summary>
/// 原型模式
/// 
/// </summary>
public class ShapeCache
{
    private static IDictionary<string, Shape> _shapeDictionary;

    public static Shape? GetShape(String shapeId)
    {
        var cachedShape = _shapeDictionary[shapeId];
        return cachedShape.Clone() as Shape;
    }

    /// <summary>
    /// 从数据库中获取形状
    /// </summary>
    public static void LoadCache()
    {
        _shapeDictionary = new Dictionary<string, Shape>
        {
            ["1"] = new Circle { Id = "1" },
            ["2"] = new Square{ Id = "2" },
            ["3"] = new Rectangle { Id = "3" },
        };
    }
}
namespace DesignPattern.CreationalPatterns.PrototypePattern.ShapeExample;
// 创建型模式

/// <summary>
/// 原型模式
/// 形状抽象类
/// </summary>
public abstract class Shape : ICloneable
{
    public string Id { get; set; }

    public string Type { get; protected set; }

    public abstract void Draw();

    public object Clone()
    {
        return MemberwiseClone();
    }
}
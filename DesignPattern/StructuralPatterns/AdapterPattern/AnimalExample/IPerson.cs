namespace DesignPattern.StructuralPatterns.AdapterPattern.AnimalExample;
// 结构型模式

/// <summary>
/// 适配器模式
/// 人接口
/// </summary>
public interface IPerson
{
    string Name { get; }
    void Speak();
}
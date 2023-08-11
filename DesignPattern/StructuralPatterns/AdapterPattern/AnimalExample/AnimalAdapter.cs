namespace DesignPattern.StructuralPatterns.AdapterPattern.AnimalExample;
// 结构型模式

/// <summary>
/// 适配器模式
/// 动物接口适配器类
/// 可以将 IPerson 类型转化为 IAnimal 类型
/// </summary>
public class AnimalAdapter : IAnimal
{
    private readonly IPerson _person;

    public AnimalAdapter(IPerson person)
    {
        _person = person;
    }

    public void Sound()
    {
        _person.Speak();
    }
}
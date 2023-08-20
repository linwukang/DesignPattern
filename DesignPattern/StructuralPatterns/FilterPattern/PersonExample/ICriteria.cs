namespace DesignPattern.StructuralPatterns.FilterPattern.PersonExample;
// 结构型模式

/// <summary>
/// 外观模式
/// 过滤器接口
/// </summary>
public interface IFilter
{
    IList<Person> MeetFilter(IList<Person> persons);
}
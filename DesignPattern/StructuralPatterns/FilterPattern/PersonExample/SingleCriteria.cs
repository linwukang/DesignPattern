namespace DesignPattern.StructuralPatterns.FilterPattern.PersonExample;
// 结构型模式

/// <summary>
/// 外观模式
/// 单身过滤器类
/// </summary>
public class SingleFilter : IFilter
{
    public IList<Person> MeetFilter(IList<Person> persons)
    {
        return persons
            .Where(person => "Single" == person.MaritalStatus)
            .ToList();
    }
}
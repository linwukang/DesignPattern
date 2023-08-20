namespace DesignPattern.StructuralPatterns.FilterPattern.PersonExample;
// 结构型模式

/// <summary>
/// 外观模式
/// 女性过滤器类
/// </summary>
public class FemaleFilter : IFilter
{
    public IList<Person> MeetFilter(IList<Person> persons)
    {
        return persons
            .Where(person => "Female" == person.Gender)
            .ToList();
    }
}
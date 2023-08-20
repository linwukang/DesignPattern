namespace DesignPattern.StructuralPatterns.FilterPattern.PersonExample;
// 结构型模式

/// <summary>
/// 外观模式
/// 男性过滤器类
/// </summary>
public class MaleFilter : IFilter
{
    public IList<Person> MeetFilter(IList<Person> persons)
    {
        return persons
            .Where(person => "Male" == person.Gender)
            .ToList();
    }
}
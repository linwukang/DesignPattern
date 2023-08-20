namespace DesignPattern.StructuralPatterns.FilterPattern.PersonExample;
// 结构型模式

/// <summary>
/// 外观模式
/// Or 过滤器类
/// </summary>
public class OrFilter : IFilter
{
    private readonly IFilter _filter;
    private readonly IFilter _otherFilter;

    public OrFilter(IFilter filter, IFilter otherFilter)
    {
        _filter = filter;
        _otherFilter = otherFilter;
    }

    public IList<Person> MeetFilter(IList<Person> persons)
    {
        var filterPersons = _filter.MeetFilter(persons);
        return filterPersons
            .Concat(_otherFilter
                .MeetFilter(persons)
                .Where(person => !filterPersons.Contains(person)))
            .ToList();
    }
}
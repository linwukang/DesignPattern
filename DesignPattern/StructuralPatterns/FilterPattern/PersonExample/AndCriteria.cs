namespace DesignPattern.StructuralPatterns.FilterPattern.PersonExample;
// 结构型模式

/// <summary>
/// 外观模式
/// And 过滤器类
/// </summary>
public class AndFilter : IFilter
{
    private readonly IFilter _filter;
    private readonly IFilter _otherFilter;

    public AndFilter(IFilter filter, IFilter otherFilter)
    {
        _filter = filter;
        _otherFilter = otherFilter;
    }

    public IList<Person> MeetFilter(IList<Person> persons)
    {
        return _otherFilter.MeetFilter(_filter.MeetFilter(persons));
    }
}
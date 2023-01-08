using Parsis.Predicate.Sdk.Contract;

namespace Parsis.Predicate.Sdk.Query.Issue;
public class QueryObjectIssue : IQueryObjectIssue
{
    public IssueKey Key
    {
        get;
        set;
    }

    public IPropertyInfo? ColumnPropertyInfo
    {
        get;
        set;
    }

    public Type? ObjectType
    {
        get;
        set;
    }
}

namespace Parsis.Predicate.Sdk.Contract;
public interface IQueryObjectIssue
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

    Type? ObjectType
    {
        get;
        set;
    }
}

public enum IssueKey
{
    Unknown = 1,
    Required = 2,
    NotRelated = 3
}

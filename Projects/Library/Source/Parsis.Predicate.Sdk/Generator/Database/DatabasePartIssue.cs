using Parsis.Predicate.Sdk.Contract;
using Parsis.Predicate.Sdk.DataType;

namespace Parsis.Predicate.Sdk.Generator.Database;
public class DatabasePartIssue : IDatabasePartIssue
{
    public DatabasePartIssueKey Key
    {
        get;
        set;
    } = DatabasePartIssueKey.Unknown;

    public QueryPartType QueryPartType
    {
        get;
        set;
    }

    public IPropertyInfo? ColumnPropertyInfo
    {
        get;
        set;
    }

    public string? Description
    {
        get;
        set;
    }
}


using Parsis.Predicate.Sdk.Contract;
using Parsis.Predicate.Sdk.Query.Issue;

namespace Parsis.Predicate.Sdk.Query;
public abstract class QueryObjectResult
{
    public  QueryObjectIssueCollection Issue
    {
        get; 
        set;
    }

    public bool IsValid
    {
        get;
        set;
    } = true;

    protected QueryObjectResult() => Issue = new QueryObjectIssueCollection();

    public void AddIssue(IQueryObjectIssue issue)
    {
        EmptyResult();
        IsValid = false;
        Issue.Add(issue);
    }

    public ICollection<IQueryObjectIssue> GetIssues() => Issue.GetIssues();

    public abstract void EmptyResult();
}

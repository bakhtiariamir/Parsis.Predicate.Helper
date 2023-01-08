using Parsis.Predicate.Sdk.Contract;

namespace Parsis.Predicate.Sdk.Query.Issue;
public class QueryObjectIssueCollection
{
    private ICollection<IQueryObjectIssue> _issues;

    public QueryObjectIssueCollection() => _issues = new List<IQueryObjectIssue>();

    public void Add(IQueryObjectIssue issue) => _issues.Add(issue);

    public ICollection<IQueryObjectIssue> GetIssues() => _issues;
}

using Parsis.Predicate.Sdk.Contract;

namespace Parsis.Predicate.Sdk.Generator.Database;
public class QueryIssue
{
    private ICollection<IDatabasePartIssue> _issues;

    private bool _isValid = true;

    public QueryIssue()
    {
        _issues = new List<IDatabasePartIssue>();
    }

    public void Add(IDatabasePartIssue issue)
    {
        _issues.Add(issue);
        _isValid = false;
    }

    public bool GetIssues(out ICollection<IDatabasePartIssue> issues)
    {
        issues = _issues;
        return _isValid;
    }
}

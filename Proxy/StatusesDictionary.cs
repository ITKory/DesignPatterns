namespace Proxy;

public class StatusesDictionary
{
    private Dictionary<int,string> _statuses;
    public StatusesDictionary()
    {
      _statuses = new()
    {
        { 0, "Ready"},
        { 1, "Not ready"},
        { 2, "In progress" },
        { 3, "Failed" }
    };
    }

    public IDictionary<int, string> GetStatuses()
    {
      
        Thread.Sleep(2000);
        return _statuses;
    }
    public int StatusesCount() => _statuses.Count;
}
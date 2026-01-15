
class Program
{
    static void Main(string[] args)
    {
       List<ISearchable> database = new List<ISearchable> ();
       database.Add(new Document("OOP Basics", "Interfaces are like contracts"));
       database.Add(new UserAccount("CSharpLover", "I love .NET"));

       SearchEngine engine = new SearchEngine();
       engine.PerformSearch(database, "Interface");
    }
}

public class SearchEngine
{
    public void PerformSearch(IEnumerable<ISearchable> items, string term)
    {
        Console.WriteLine($"Searching for: {term}...");
        foreach(var item in items)
        {
            if (item.ContainsKeyword(term))
            {
                Console.WriteLine($"Match found in : {item.GetType().Name}");
            }
        }
    }
}
public interface ISearchable
{
   bool ContainsKeyword(string keyword);
}

public class Document : ISearchable
{
    public string Title{get;set;}
    public string Content{get;set;}

    public Document(string title, string content)
    {
        Title = title;
        Content = content;
    }

    public bool ContainsKeyword(string keyword)
    {
        return Content.Contains(keyword) || Title.Contains(keyword);
    }
}
public class UserAccount : ISearchable
{
    public string Username { get; set; }
    public string Bio { get; set; }

    public UserAccount(string username, string bio)
    {
        Username = username;
        Bio = bio;
    }

    public bool ContainsKeyword(string keyword)
    {
        return Username.Equals(keyword, StringComparison.OrdinalIgnoreCase);
    }
}
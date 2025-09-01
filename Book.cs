namespace lab1.Models;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int TotalPages { get; set; }
    public int CurrentPage { get; set; }
}

public override string ToString()
{
    return $"{Title} - {Author}. {CurrentPage}/{TotalPages} pages.";
}
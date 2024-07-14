// Author.cs
public class Author
{
    public int Id { get; set; }
    public string Name { get; set; }
}

// Book.cs
public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int AuthorId { get; set; }
    public Author Author { get; set; }
}
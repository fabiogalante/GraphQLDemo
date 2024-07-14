namespace GraphQLDemo;

// BookRepository.cs
public class BookRepository
{
    private readonly List<Author> _authors = new List<Author>();
    private readonly List<Book> _books = new List<Book>();

    public BookRepository()
    {
        var author1 = new Author { Id = 1, Name = "Author 1" };
        var author2 = new Author { Id = 2, Name = "Author 2" };

        _authors.Add(author1);
        _authors.Add(author2);

        _books.Add(new Book { Id = 1, Title = "Book 1", AuthorId = 1, Author = author1 });
        _books.Add(new Book { Id = 2, Title = "Book 2", AuthorId = 1, Author = author1 });
        _books.Add(new Book { Id = 3, Title = "Book 3", AuthorId = 2, Author = author2 });
    }

    public List<Book> GetBooks() => _books;
    public List<Author> GetAuthors() => _authors;
}
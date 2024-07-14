namespace GraphQLDemo;

// Query.cs
public class Query
{
    private readonly BookRepository _repository;

    public Query(BookRepository repository)
    {
        _repository = repository;
    }

    public List<Book> GetBooks() => _repository.GetBooks();
    public List<Author> GetAuthors() => _repository.GetAuthors();
}
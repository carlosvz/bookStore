using System.Collections.Generic;

namespace BookStore.Domain.Contracts
{
    public interface IBookRepository : IBookRepository<Book>
    {
        List<Book> GetWithAuthors(int skyp = 0, int taken = 25);
        Book GetWithAuthors(int id);
    }
}

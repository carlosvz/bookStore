using BookStore.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain;

namespace BookStore.Data.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        public void Create(Author Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Author> Get(int skip = 0, int take = 25)
        {
            throw new NotImplementedException();
        }

        public Author Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Author Entity)
        {
            throw new NotImplementedException();
        }
    }
}

using BookStore.Domain.Contracts;
using System.Collections.Generic;
using System.Linq;
using BookStore.Domain;
using BookStore.Data.DataContexts;
using System.Data.Entity;

namespace BookStore.Data.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private BookStoreDataContext _db;

        public AuthorRepository()
        {
            this._db = new BookStoreDataContext();
        }

        public List<Author> Get(int skip = 0, int take = 25)
        {
            return _db.Authors.OrderBy(x => x.LastName).Skip(skip).Take(take).ToList();
        }

        public Author Get(int id)
        {
            return _db.Authors.Find(id);
        }

        public void Create(Author entity)
        {
            _db.Authors.Add(entity);
            _db.SaveChanges();
        }

        public void Update(Author entity)
        {
            _db.Entry<Author>(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            _db.Authors.Remove(_db.Authors.Find(id));
            _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}

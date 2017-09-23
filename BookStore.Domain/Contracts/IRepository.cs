using System;
using System.Collections.Generic;

namespace BookStore.Domain.Contracts
{
    public interface IRepository<T> : IDisposable
    {
        List<T> Get(int skip = 0, int take = 25);
        T Get(int id);
        void Create(T Entity);
        void Delete(int id);
        void Update(T Entity);
    }
}

using Akib_1281742.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akib_1281742.Responsitories
{
    public interface IGenecricRepostory<T> where T : EntityBase, new()
    {
        IEnumerable<T> Get();
        T Get(int id);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void Delete(int id);
    }
}

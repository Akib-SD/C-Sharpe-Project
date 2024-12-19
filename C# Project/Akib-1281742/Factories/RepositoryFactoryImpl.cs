using Akib_1281742.Model;
using Akib_1281742.Responsitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akib_1281742.Factories
{
    public class RepositoryFactoryImpl : IRepositoryFactory
    {
        public IGenecricRepostory<T> GetRepo<T>() where T : EntityBase, new()
        {
            return new GenericRepositoryImpl<T>();
        }
    }
}

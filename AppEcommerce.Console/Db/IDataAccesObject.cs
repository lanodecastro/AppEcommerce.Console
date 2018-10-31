using AppEcommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEcommerce.Db
{
    public interface IDataAccesObject<T>
    {
        void Save(T obj);
        void Update(T obj);
        void Delete(object primaryKey);
        IList<T> GetAll();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop.Infrastucture
{
    public interface IBaseRepository<T>
    {
        T create(T entity);
        T getOne();
    }
}

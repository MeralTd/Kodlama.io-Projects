using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Concrete
{
    public interface ICRUDService<T>
    {
        void Save(T input);
        void Update(T input);
        void Delete(T input);
    }
}

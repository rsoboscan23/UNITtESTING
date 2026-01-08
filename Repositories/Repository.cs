using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public abstract class Repository<T> where T : class
    {
        protected List<T> items;

        public Repository()
        {
            InitializeItems();
        }

        protected virtual void InitializeItems()
        {
            items = new List<T>();
        }

        public virtual List<T> GetAll()
        {
            return items.ToList();
        }

        public virtual void Add(T item)
        {
            items.Add(item);
        }
        
        public virtual void Remove(T item)
        {
            items.Remove(item);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10032019
{
    class RoundTable<T> : IEnumerable<T> where T : INameable, IComparable<T>
    {
        List<T> entites = new List<T>();

        public void Add(T entity)
        {
            entites.Add(entity);
            
        }
        public void RemoveAt(int index)
        {
            if (entites.Count == 0)
                return;

            entites.RemoveAt(index % entites.Count);
        }
        public void Clear()
        {
            entites.Clear();
        }
        public void InsertAt(int index, T item)
        {
            entites.Insert(index % entites.Count,item);
        }
        public void Sort()
        {
            entites.Sort();
        }
        public List<T> GetRounded(int length)
        {
            List<T> result = new List<T>();
            int counter = 0;
            int index = 0;
            while(counter++ < length)
            {
                result.Add(entites[index++]);
                    if (index >= entites.Count)
                     index = 0;
            }
            return result;

        }
        public IEnumerator<T> GetEnumerator()
        {
            return entites.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return entites.GetEnumerator();
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public T this [int index]
        {
            get
            {
                if (entites.Count == 0)
                    return default(T);
                return entites[index % entites.Count];
            }
        }
        public T this [string name]
        {
            get
            {
                if (entites.Count == 0)
                    return default(T);

                foreach(T entity in entites)
                {
                    if (entity.Name == name)
                        return entity;
                }

                return default(T);
            }
        }
    }
}

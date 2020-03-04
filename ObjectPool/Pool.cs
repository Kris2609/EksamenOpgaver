using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPool
{
    public class Pool<T> where T : IPoolObject, new()
    {
        private Queue<T> queue = new Queue<T>();

        public T Get()
        {
            if (queue.Count == 0)
            {
                return new T();
            }
            else
            {
                return queue.Dequeue();
            }
        }
        public void Release(T item)
        {
            item.Reset();
            queue.Enqueue(item);
        }
    } 
    
}

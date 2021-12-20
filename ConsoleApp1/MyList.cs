using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Extention
{
    public class MyList <T>
    {
        public T[] list;
        public int count;
        public string List;
        public MyList()
        {
            list = new T[10];
        }
        private void ArrayResize()
        {
            Array.Resize(ref list, list.Length + 10);
        }
        public void Add(T obj)
        {
            if ((count != 0) && (count % 10 == 0))
            {
                ArrayResize();
            }
            list[count] = obj;
            count++;
            Console.WriteLine(obj);
        }
        public void Clear()
        {
            count = 0;
            for (int i = 0; i < list.Length; i++)
            {
                list[count] = list[list.Length - 1];
                count++;
            }
            Console.Clear();
        }
        public void AddRange(T list)
        {
            Add(list);
        }
        public bool Contains(T obj)
        {
            foreach (var item in list)
            {
                if (Comparer<T>.Default.Compare(item, obj) == 0)
                {
                    return true;
                }
            }
            return false;

        }
        public T Find(Predicate<T> func)
        {
            foreach (var item in list)
            {
                if (func(item))
                {
                    return item;
                }
            }
            return default;

        }
    }
}

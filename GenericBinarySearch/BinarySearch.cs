using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBinarySearch
{
    public class BinarySearch<T>
    {

        T[] arr;

        Comparison<T> cmp;

        public BinarySearch(T[] arr, Comparison<T> cmp)
        {

            if (arr == null)
                throw new ArgumentNullException();

            if (cmp == null)
                throw new ArgumentNullException();

            this.arr = new T[arr.Length];
            arr.CopyTo(this.arr, 0);

            this.cmp = new Comparison<T>(cmp);

            Array.Sort(this.arr, this.cmp);
        }




        public int Search(T elem)
        {
            int i = arr.Length / 2;
            if (cmp(arr[i], elem) == 0)
                return i;
            else if (cmp(arr[i], elem) > 0)
                return Search(elem, 0, i - 1);
            else
                return Search(elem, i + 1, arr.Length - 1);
        }

        private int Search(T elem, int start, int end)
        {
            return 0;
        }


    }
}

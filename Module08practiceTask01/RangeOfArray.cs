using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08practiceTask01
{
    public class RangeOfArray
    {
        private int[] array;
        private int lowerBound;
        private int upperBound;

        public RangeOfArray(int lowerBound, int upperBound)
        {
            this.lowerBound = lowerBound;
            this.upperBound = upperBound;
            int size = upperBound - lowerBound + 1;
            array = new int[size];
        }

        public int this[int index]
        {
            get
            {
                if (IsIndexValid(index))
                {
                    return array[index - lowerBound];
                }
                throw new IndexOutOfRangeException("Index is out of range.");
            }
            set
            {
                if (IsIndexValid(index))
                {
                    array[index - lowerBound] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
            }
        }

        private bool IsIndexValid(int index)
        {
            return index >= lowerBound && index <= upperBound;
        }
    }

}

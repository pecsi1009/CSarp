/*
    5.Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. Keep the elements of the list in an
array with fixed capacity which is given as parameter in the class constructor. Implement methods for adding element, accessing element 
by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString().
Check all input parameters to avoid accessing elements at invalid positions.
   6.Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
   7.Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. You may need to add
a generic constraints for the type T.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Point3DMain
{
    class GenericList<T>
    {
        private const int capacity = 20; 
        private T[] elements;
        private int count;


        //Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor
        public GenericList(int capacity)
        {
            elements = new T[capacity];
        }
        public GenericList(): this(capacity)
        {
        }

        //Property
        public int Count
        {
            get
            {
                return this.count=0;
            }
        }
        
        
        //method for adding element
        public void AddElements(T element)
        {
            if (count < capacity)
            {
                elements[count] = element;
                count++;
            }
            else 
            {
                // we make methods ArrayGrow, because we try to put element, in full array (<capacity)
                AutoGrow();
                elements[count] = element;
                count++;
            }
        }

        // 6.Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it
        public void AutoGrow()
        {
            T[] copyArray = new T[2*elements.Length];
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = copyArray[i];
            }
            elements[T] = copyArray[T];

        }
        // method accessing element by index
        public T this[int index]
        {
            get
            {
                if (index >= count)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Index must be < count: {0}.", index));
                }
                T result = elements[index];
                return result;
            }
        }
        //method removing element by index
        public void Remove(int index)
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }
            T[] newArray = new T[elements.Length - 1];
            for (int i = 0, j = 0; i < newArray.Length; i++, j++)
            {
                if (i == index)
                {
                    j++;
                }
                newArray[i] = elements[j];
            }
            count--;
            elements = newArray;
        }
        // method inserting element at given position
        public void Insert(T element, int index)
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
            }
            T[] newArray = new T[elements.Length + 1];
            for (int i = 0, j = 0; j < newArray.Length; i++, j++)
            {
                T temp = elements[i];
                if (i == index)
                {
                    j++;
                    newArray[i] = element;
                }
                newArray[j] = temp;
            }
            count++;
            elements = newArray;
        }
        //method clearing the list
        public void Clear()
        {
            count = 0;
            elements = new T[capacity];
        }

        public void FindElement<T>(T element, GenericList<T> elements)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i].Equals(element))
                {
                    Console.WriteLine("The element is at index:{0}", i);
                    return;
                }
            }
            Console.WriteLine("No such element!");
        }
        //method finding element by its value and ToString()
        public override string ToString()
        {
            StringBuilder console = new StringBuilder();
            for (int i = 0; i < elements.Length; i++)
            {
                console.Append(elements[i]);
                console.Append(" ");
            }
            return console.ToString();
        }
        //Create generic methods Min<T>() and Max<T>() 
        public T Min<T>()
        {
            Array.Sort(elements);
            T minElement = elements[0];
            return minElement;
        }
        public T Max<T>()
        {
            Array.Sort(elements);
            T maxElement = elements[elements.Length];
            return maxElement;
        }
    }
}

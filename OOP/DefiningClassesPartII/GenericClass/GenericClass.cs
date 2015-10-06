/*Task 5
 * Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
 * Keep the elements of the list in an array with fixed capacity which is given as parameter in
 * the class constructor. Implement methods for adding element, accessing element by index,
 * removing element by index, inserting element at given position, clearing the list, finding
 * element by its value and ToString(). Check all input parameters to avoid accessing elements
 * at invalid positions.
 * 
 * Task 6
 * Implement auto-grow functionality: when the internal array is full, create a new array of
 * double size and move all elements to it.
 * 
 * Task 7
 * Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element
 * in the  GenericList<T>. You may need to add a generic constraints for the type T.
 */


using System;

public class GenericList<T>
{
    const int DefaultCapacity = 4;

    private T[] elements;
    private int count = 0;
    private int capacity = DefaultCapacity;

    public GenericList(int capacity = DefaultCapacity)
    {
        elements = new T[capacity];
    }

    public int Count
    {
        get
        {
            return this.count;
        }
    }

    public int Capacity
    {
        get
        {
            return this.capacity;
        }
    }

    public void Add(T element)
    {
        if (count >= elements.Length)
        {
            AutoGrow();
        }

        this.elements[count] = element;
        count++;
    }

    public T this[int index]
    {
        get
        {
            if (index >= count || index < 0)
            {
                throw new IndexOutOfRangeException(String.Format("You are triyng to get element with invalid index"));
            }

            T result = elements[index];
            return result;
        }
    }

    public void RemoveAt(int index)
    {
        if (index >= count || index < 0)
        {
            throw new IndexOutOfRangeException(String.Format("You are triyng to remove element with invalid index"));
        }
        
        T[] tmp = new T[count];
        int tmpCount = 0;
        int n = 0;
        for (int i = 0; i < count; i++)
        {
            if (i == index)
            {
                n++;
                tmp[i] = elements[n];
                tmpCount++;
            }
            else
            {
                tmp[i] = elements[n];
                tmpCount++;
            }

            n++;
        }

        count = tmpCount;

        for (int i = 0; i < count; i++)
        {
            elements[i] = tmp[i];
        }
    }

    public void Insert(T element, int index)
    {
        if (index >= count || index < 0)
        {
            throw new IndexOutOfRangeException(String.Format("You are triyng to insert element with invalid index"));
        }

        T[] tmp = new T[count + 1];
        for (int i = 0; i < count + 1; i++)
        {
            if (i < index)
            {
                tmp[i] = elements[i];
            }
            else if (i == index)
            {
                tmp[i] = element;
            }
            else
            {
                tmp[i] = elements[i - 1];
            }
        }

        count++;

        //elements = tmp;

        for (int i = 0; i < count; i++)
        {
            elements[i] = tmp[i];
        }
    }

    public void Clear()
    {
        elements = null;
        count = 0;
    }

    public int FindIndex(T element)
    {
        int index = -1;
        for (int i = 0; i < count; i++)
		{
			 if (elements[i].Equals(element))
            {
                index = i;
                return index;
            }
		}

        return index;
    }

    public override string ToString()
    {
        string output;
        if (elements != null)
        {
            output = String.Join(",", elements);
        }
        else
        {
            output = "The list is empty!";
        }
        
        return output;
    }

    private void AutoGrow()
    {
        T[] tmp = new T[capacity * 2];
        Array.Copy(elements, tmp, count);
        elements = tmp;
    }

    public T Min<T>() where T : IComparable<T>
    {
        dynamic minimal = elements[0];
        T min;
        for (int i = 0; i < count -1; i++)
        {
            T first = (dynamic)elements[i];
            T second = (dynamic)elements[i + 1];

            if (first.CompareTo(second) <= 0)
            {
                min =  first;
            }
            else
            {
                min = second;
            }

            if (min.CompareTo(minimal) <= 0)
            {
                minimal = min;
            }
        }

        return minimal;

    }

    public T Max<T>() where T : IComparable<T>
    {
        dynamic maximal = elements[0];
        T max;
        for (int i = 0; i < elements.Length - 1; i++)
        {
            T first = (dynamic)elements[i];
            T second = (dynamic)elements[i + 1];

            if (first.CompareTo(second) >= 0)
            {
                max = first;
            }
            else
            {
                max = second;
            }

            if (max.CompareTo(maximal) >= 0)
            {
                maximal = max;
            }
        }

        return maximal;

    }
    
}
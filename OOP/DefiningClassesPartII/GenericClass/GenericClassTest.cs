using System;


class GenericClassTest
{
    static void Main()
    {
        GenericList<int> listInt = new GenericList<int>();

        Console.WriteLine("It has been created new Generic list of (int) with capacity {0}", listInt.Capacity);

        for (int i = 0; i < listInt.Capacity + 1; i++)
        {
            Console.Write("Add an element to the list: ");
            int element = int.Parse(Console.ReadLine());
            listInt.Add(element);
        }

        Console.WriteLine("The list is filled with {0} elements.", listInt.Count);
        Console.WriteLine("And the elements are: " + listInt.ToString());

        Console.WriteLine("The smaller element is: {0}", listInt.Min<int>());
        Console.WriteLine("The bigger  element is: {0}", listInt.Max<int>());

        Console.WriteLine("Let's remove element on position [3]");
        listInt.RemoveAt(3);
        Console.WriteLine("The new list is: " + listInt.ToString());

        Console.WriteLine("I think we made a mistake! Let's get back the element at position [3]!");
        Console.Write("Add element: ");
        int newElement = int.Parse(Console.ReadLine());
        listInt.Insert(newElement, 3);

        Console.WriteLine("Ok, let's find an element on it's value!");
        Console.Write("Enter value: ");
        int value = int.Parse(Console.ReadLine());

        if (listInt.FindIndex(value) > -1)
        {
            Console.WriteLine("The index of the value is {0}", listInt.FindIndex(value));
        }
        else
        {
            Console.WriteLine("There's no such value!");
        }

        Console.WriteLine("That's enough! We should clear the list!");
        listInt.Clear();
        Console.WriteLine("Let's check: " + listInt.ToString());

    }
}


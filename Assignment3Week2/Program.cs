using System;
using System.Collections.Generic;

class CollectionsAssignment
{
    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\nChoose an example to run:");
            Console.WriteLine("1. Queue<T> Example");
            Console.WriteLine("2. PriorityQueue<T> Example");
            Console.WriteLine("3. Stack<T> Example");
            Console.WriteLine("4. LinkedList<T> Example");
            Console.WriteLine("5. Dictionary<TKey, TValue> Example");
            Console.WriteLine("6. SortedList<TKey, TValue> Example");
            Console.WriteLine("7. HashSet<T> Example");
            Console.WriteLine("8. List<T> Example");
            Console.WriteLine("9. Quit");
            Console.Write("Enter your choice (1-9): ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    QueueExample();
                    break;
                case 2:
                    PriorityQueueExample();
                    break;
                case 3:
                    StackExample();
                    break;
                case 4:
                    LinkedListExample();
                    break;
                case 5:
                    DictionaryExample();
                    break;
                case 6:
                    SortedListExample();
                    break;
                case 7:
                    HashSetExample();
                    break;
                case 8:
                    ListExample();
                    break;
                case 9:
                    Console.WriteLine("Goodbye.");
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }

        } while (choice != 9);
    }

    static void QueueExample()
    {
        /*
        Add 5 items.
        Check to see if the queue contains a specific item and display a message. (Do not remove this item from the queue.)
        Remove at least 1 different item from the queue.
        Count the items in the queue and display the count.
        Print all the items in the queue.
         */
        Console.WriteLine("\nQueue<T> Example:");

        Queue<string> queue = new Queue<string>();

        queue.Enqueue("C#");
        queue.Enqueue("Python");
        queue.Enqueue("TypeScript");
        queue.Enqueue("Java");
        queue.Enqueue("Swift");

        Console.WriteLine(queue.Contains("TypeScript") ? "Queue contains TypeScript." : "Queue does not contain TypeScript.");

        queue.Dequeue();

        Console.WriteLine($"Queue count: {queue.Count}");

        Console.WriteLine("Items in the queue:");
        foreach (string item in queue)
        {
            Console.WriteLine(item);
        }
    }

    static void PriorityQueueExample()
    {
        /*
        Add 5 items.
        Find and display the highest priority item, then remove the item.
        Continue displaying the highest priority item and removing it until all items are removed.
        */
        Console.WriteLine("\nPriorityQueue<T> Example:");
        
        PriorityQueue<string, int> priorityQueue = new PriorityQueue<string, int>();

        priorityQueue.Enqueue("string1", 7);
        priorityQueue.Enqueue("string2", 2);
        priorityQueue.Enqueue("string3", 5);
        priorityQueue.Enqueue("string4", 1);
        priorityQueue.Enqueue("string5", 3);

        Console.WriteLine("PriorityQueue items in descending order:");
        while (priorityQueue.Count > 0)
        {
            var highestPriority = priorityQueue.Dequeue();
            Console.WriteLine(highestPriority);
        }
        
    }

    static void StackExample()
    {
        /*
        Add 5 items.
        Check to see if the stack contains a specific item and display a message.
        Remove at least 1 item.
        Count the items in the stack and display the count.
        Print all the items in the stack.
        */
        Console.WriteLine("\nStack<T> Example:");

        Stack<string> stack = new Stack<string>();

        stack.Push("C#");
        stack.Push("Python");
        stack.Push("TypeScript");
        stack.Push("Java");
        stack.Push("Swift");

        Console.WriteLine(stack.Contains("TypeScript") ? "Stack contains TypeScript." : "Stack does not contain TypeScript.");

        stack.Pop();

        Console.WriteLine($"Stack count: {stack.Count}");

        Console.WriteLine("Items in the stack:");
        foreach (string item in stack)
        {
            Console.WriteLine(item);
        }
    }

    static void LinkedListExample()
    {
        /*
        Add 5 items to a linked list.
        Retrieve and display the first node.
        Retrieve and display the last node.
        Add a 6th item to the middle of the list.
        Remove a node from the list (it can be the first, last, or a node with a specific value).
        Count the items in linked list and display the count.
        Print all the items in the linked list.
        */
        Console.WriteLine("\nLinkedList<T> Example:");

        LinkedList<string> linkedList = new LinkedList<string>();

        linkedList.AddLast("C#");
        linkedList.AddLast("Python");
        linkedList.AddLast("TypeScript");
        linkedList.AddLast("Java");
        linkedList.AddLast("Swift");

        Console.WriteLine($"First node: {linkedList.First.Value}");

        Console.WriteLine($"Last node: {linkedList.Last.Value}");

        // Add a 6th item to the middle of the list
        linkedList.AddAfter(linkedList.Find("TypeScript"), "JavaScript");

        linkedList.Remove("Python");

        Console.WriteLine($"Linked list count: {linkedList.Count}");

        Console.WriteLine("Items in the linked list:");
        foreach (string item in linkedList)
        {
            Console.WriteLine(item);
        }
    }

    static void DictionaryExample()
    {
        /*
        Add 5 items to a dictionary
        Retrieve and display all the keys
        Retreive and display all the values
        Retrieve and display both the keys and the values
        Remove an item from the dictionary
        Display a count of the dictionary items.
         */
        Console.WriteLine("\nDictionary<TKey, TValue> Example:");

        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        dictionary.Add("Uno", "C#");
        dictionary.Add("Dos", "Python");
        dictionary.Add("Tres", "TypeScript");
        dictionary.Add("Quatro", "Java");
        dictionary.Add("Cinco", "Swift");

        Console.WriteLine("Keys in the dictionary:");
        foreach (string key in dictionary.Keys)
        {
            Console.WriteLine(key);
        }

        Console.WriteLine("Values in the dictionary:");
        foreach (string value in dictionary.Values)
        {
            Console.WriteLine(value);
        }

        Console.WriteLine("Keys and values in the dictionary:");
        foreach (KeyValuePair<string, string> pair in dictionary)
        {
            Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
        }

        dictionary.Remove("Dos");

        Console.WriteLine($"Dictionary count: {dictionary.Count}");
    }

    static void SortedListExample()
    {
        /*
        Add 5 items to a sorted list
        Allow the user to enter a key and value (you will need to check to see if the key exists and handle the problem)
        Remove an item from the list (this code can be combined with #2 above if you include this in your error handling)
        Print the key and value for your sorted list.
        */
        Console.WriteLine("\nSortedList<TKey,TValue> Example:");

        SortedList<int, string> sortedList = new SortedList<int, string>();

        sortedList.Add(10, "TypeScript");
        sortedList.Add(20, "C#");
        sortedList.Add(50, "Swift");
        sortedList.Add(40, "Python");
        sortedList.Add(30, "Java");

        Console.Write("Enter an integer key to add: ");
        int key = int.Parse(Console.ReadLine());
        Console.Write("Enter a value: ");
        string value = Console.ReadLine();

        if (sortedList.ContainsKey(key))
        {
            Console.WriteLine("Key already exists.");
        }
        else
        {
            sortedList.Add(key, value);
        }

        sortedList.RemoveAt(0);

        Console.WriteLine("Keys and values in the sorted list:");
        foreach (KeyValuePair<int, string> pair in sortedList)
        {
            Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
        }
    }
    static void HashSetExample()
    {
        /*
        Add 5 items to a hashset object
        Create a similar hashset object with 5 items.
        Create a third hashset object and add 5 more items 
        (2 items should be the same as your first or second object)
        Use a command to combine the first and second object. 
        Store the combined items in the first object and print out the combined list.
        Create a new hashset object to store duplicates and use a command to display items 
        that appear in both the first object and your third object. 
        Store the results in your new hashset object. 
        Print out the contents of the object
        */
        Console.WriteLine("\nHashSet<T> Example:");

        HashSet<string> hashSet1 = new HashSet<string>();

        hashSet1.Add("C#");
        hashSet1.Add("Python");
        hashSet1.Add("TypeScript");
        hashSet1.Add("Java");
        hashSet1.Add("Swift");

        HashSet<string> hashSet2 = new HashSet<string>();

        hashSet2.Add("React");
        hashSet2.Add("jQuery");
        hashSet2.Add("Angular");
        hashSet2.Add("Vue");
        hashSet2.Add("TypeScript");

        HashSet<string> hashSet3 = new HashSet<string>();

        hashSet3.Add("Django");
        hashSet3.Add("Spring");
        hashSet3.Add("C#");
        hashSet3.Add("Express");
        hashSet3.Add("Laravel");

        hashSet1.UnionWith(hashSet2);

        Console.WriteLine("Combined items in hashSet1:");
        foreach (string item in hashSet1)
        {
            Console.WriteLine(item);
        }

        HashSet<string> duplicates = new HashSet<string>(hashSet1);

        duplicates.IntersectWith(hashSet3);

        Console.WriteLine("Duplicates in hashSet1 and hashSet3:");
        foreach (string item in duplicates)
        {
            Console.WriteLine(item);
        }
    }

    static void ListExample()
    {
        /*
        Add 5 items to a list
        Use the AddRange() method to add 3 more items to a list
        Sort the list and print all the items
        Remove at least 1 item
        Sort the list in reverse order and print all items.
        */
        Console.WriteLine("\nList<T> Example:");

        List<string> list = new List<string>();

        list.Add("C#");
        list.Add("Python");
        list.Add("TypeScript");
        list.Add("Java");
        list.Add("Swift");

        list.AddRange(new string[] { "React", "Vue", "Angular" });

        list.Sort();
        Console.WriteLine("Sorted list:");
        foreach (string item in list)
        {
            Console.WriteLine(item);
        }

        list.Remove("TypeScript");

        list.Sort((x, y) => y.CompareTo(x));
        Console.WriteLine("Sorted list in reverse order:");
        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
    }
}





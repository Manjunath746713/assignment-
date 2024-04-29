using System;
using System.Collections;
class airfssrhs
{
    static void Main()
    {
        
        ArrayList arrayList = new ArrayList();
        arrayList.Add("One");
        arrayList.Add("Two");
        arrayList.Insert(1, "Three"); 
        Console.WriteLine("ArrayList:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        
        arrayList.Remove("Two");
        Console.WriteLine("ArrayList after removing 'Two':");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
       
        Console.WriteLine("Index of 'Three' in ArrayList: " + arrayList.IndexOf("Three"));
        Console.WriteLine();
       
        arrayList[0] = "NewOne";
        Console.WriteLine("ArrayList after replacing 'One' with 'NewOne':");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        
        Hashtable hashtable = new Hashtable();
        hashtable.Add(1, "One");
        hashtable.Add(2, "Two");
        hashtable.Add(3, "Three");
       
        hashtable[4] = "Four";
        Console.WriteLine("Hashtable:");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine(entry.Key + ": " + entry.Value);
        }
        Console.WriteLine();
       
        hashtable.Remove(2);
        Console.WriteLine("Hashtable after removing key 2:");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine(entry.Key + ": " + entry.Value);
        }
        Console.WriteLine();
        
        Console.WriteLine("Value for key 3 in Hashtable: " + hashtable[3]);
        Console.WriteLine();
        
        hashtable[1] = "NewOne";
        Console.WriteLine("Hashtable after replacing key 1:");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine(entry.Key + ": " + entry.Value);
        }
        Console.WriteLine();
        
        SortedList sortedList = new SortedList();
        sortedList.Add(3, "Three");
        sortedList.Add(1, "One");
        sortedList.Add(2, "Two");
        
        sortedList[4] = "Four";
        Console.WriteLine("SortedList:");
        foreach (DictionaryEntry entry in sortedList)
        {
            Console.WriteLine(entry.Key + ": " + entry.Value);
        }
        Console.WriteLine();
        
        sortedList.Remove(2);
        Console.WriteLine("SortedList after removing key 2:");
        foreach (DictionaryEntry entry in sortedList)
        {
            Console.WriteLine(entry.Key + ": " + entry.Value);
        }
        Console.WriteLine();
        
        Console.WriteLine("Value for key 3 in SortedList: " + sortedList[3]);
        Console.WriteLine();
        
        sortedList[1] = "NewOne";
        Console.WriteLine("SortedList after replacing key 1:");
        foreach (DictionaryEntry entry in sortedList)
        {
            Console.WriteLine(entry.Key + ": " + entry.Value);
        }
        Console.WriteLine();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableApp
{

    class Program
    {

            static void Main(string[] args)
        {
            Console.WriteLine("HashTable 예제");

            System.Collections.Hashtable ht = new System.Collections.Hashtable();
            ht["일"] = "One";
            ht["이"] = "Two";
            ht["삼"] = "Three";
            ht["사"] = "Four";

            foreach (System.Collections.DictionaryEntry item in ht)
                Console.WriteLine($"{item.Key} : {item.Value}");

            int[] arr = { 123, 456, 789 };
            System.Collections.ArrayList list = new System.Collections.ArrayList(arr);

        }
    }
}

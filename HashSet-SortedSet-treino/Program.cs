using System;
using System.Collections.Generic;

namespace HashSet_SortedSet_treino {
    class Program {
        static void Main(string[] args) {

            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");


            Console.WriteLine(set.Contains("TV");

            foreach(string p in set) {
                Console.WriteLine(p);
            }

        }
    }
}

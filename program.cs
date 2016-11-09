using System;
using System.Collections.Generic;
using System.Linq;

namespace string_to_int
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            IEnumerable<int> collec = Console.ReadLine().Split(' ').Where(n => int.TryParse(n, out i)).Select(n => int.Parse(n));
            foreach (var v in collec)
                Console.WriteLine(v);
            Console.ReadLine();
        }
    }
}


INPUT :-
1 2 123 1wqe dsaw fed31 eQ E    2 QW    123 13 2WE QSD WDSA 12.12 12.12.12.123. 123123

OUTPUT:-
1
2
123
123
13
123123

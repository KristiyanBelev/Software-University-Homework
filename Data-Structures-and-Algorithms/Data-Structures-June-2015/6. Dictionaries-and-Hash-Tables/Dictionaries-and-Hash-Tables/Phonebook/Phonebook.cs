using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Phonebook
    {
        static void Main()
        {
            var phonebook = new Dictionary<string, string>();
            var input = "";
            bool isSearching = false;
            // Adding the contacts
            while (!isSearching)
            {
                input = Console.ReadLine();
                if (input != "search")
                {
                    var entry = input.Split('-');
                    phonebook.Add(entry[0].ToString(), entry[1].ToString());
                }
                else
                {
                    isSearching = true;
                }
            }

            // Reading searched entries
            bool isFinished = false;
            var searchedEntries = new List<string>();
            while (!isFinished)
            {
                input = Console.ReadLine();
                if (input == "")
                {
                    isFinished = true;
                }
                else
                {
                    searchedEntries.Add(input);
                }
            }

            // Printing the output
            foreach (var key in searchedEntries)
            {
                if (phonebook.ContainsKey(key))
                {
                    Console.WriteLine("{0} -> {1}", key, phonebook[key]);
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", key);
                }
            }
        }
    }
}
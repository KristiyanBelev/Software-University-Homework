using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;

class StringEditor
{
    static void Main()
    {
        var rope = new BigList<char>();
        string input = "";

        while (input != "END")
        {
            input = Console.ReadLine();
            var inputTokens = input.Trim().Split(' ');
            var command = inputTokens[0];

            if (command == "APPEND")
            {
                var textToAppend = input.Substring(7);
                for (int i = 0; i < textToAppend.Length; i++)
                {
                    rope.Add(textToAppend[i]);
                }
                Console.WriteLine("OK");
            }

            if (command == "INSERT")
            {
                int positionToInsert = int.Parse(inputTokens[1]);
                if (IsValidIndex(positionToInsert, rope))
                {
                    var textToInsert = inputTokens[2];
                    rope.InsertRange(positionToInsert, textToInsert);
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            }

            if (command == "DELETE")
            {
                int deleteFrom = int.Parse(inputTokens[1]);
                int deleteCount = int.Parse(inputTokens[2]);
                if ((IsValidIndex(deleteFrom, rope) && IsValidIndex(deleteCount, rope)) && ((deleteFrom + deleteCount) <= rope.Count))
                {
                    rope.RemoveRange(deleteFrom, deleteCount);
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("ERROR");
                }

            }

            if (command == "REPLACE")
            {
                int replaceFrom = int.Parse(inputTokens[1]);
                int replaceCount = int.Parse(inputTokens[2]);

                if ((IsValidIndex(replaceFrom, rope) && IsValidIndex(replaceCount, rope)) && ((replaceFrom + replaceCount) <= rope.Count))
                {
                    var replaceText = new List<string>();
                    for (int i = 3; i < inputTokens.Length; i++)
                    {
                        replaceText.Add(inputTokens[i]);
                    }

                    rope.RemoveRange(replaceFrom, replaceCount);
                    rope.InsertRange(replaceFrom, string.Join(" ", replaceText));

                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            }

            if (command == "PRINT")
            {
                Console.WriteLine(string.Join("", rope));
            }
        }
    }

    static bool IsValidIndex(int index, BigList<char> rope)
    {
        if (index >= rope.Count || index < 0)
        {
            return false;
        }

        return true;
    }
}
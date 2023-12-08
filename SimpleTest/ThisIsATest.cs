using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//simple test

//Test 


namespace SimpleTest
{
    public static class MyTest
    {
        public static string CalculateTotal(string someInput , ILogger logger)
        {
            if (someInput == null)
            {
                throw new DataMisalignedException("data not correct");
            }
            
            logger.Log("start CalculateTotal");

            string output = Output(someInput);

            logger.Log("end CalculateTotal");

            return output;            
        }

        private static string Output(string input)
        {
            char[] removeChars = { '.', ',', '\'', ';' };
            string cleansedInput = CleansedInput(input, removeChars);
            List<KeyValuePair<string, string>> inputList = new List<KeyValuePair<string, string>>();

            List<KeyValuePair<string, string>> reorderedInputList;
            string[] strings;

            foreach (string word in cleansedInput.Split(' '))
            {
                inputList.Add(new KeyValuePair<string, string>(word.ToUpper(), word));
            }

            reorderedInputList = inputList.OrderBy(x => x.Key).ThenByDescending(x => x.Value).ToList();

            strings = reorderedInputList.Select(x => x.Value).ToArray();

            return string.Join(" ", strings);

        }

        private static string CleansedInput(string input, char[] removeChars)
        {
            StringBuilder stringBuilder;
            List<string> cleansedWords = new List<string>();

            foreach (string word in input.Split(' ').ToList())
            {
                stringBuilder = new StringBuilder();

                foreach (char c in word)
                {
                    if (!removeChars.Contains(c))
                    {
                        stringBuilder.Append(c);
                    }
                }

                cleansedWords.Add(stringBuilder.ToString());
            }

            return string.Join(" ", cleansedWords.ToArray());
        }

    }
}

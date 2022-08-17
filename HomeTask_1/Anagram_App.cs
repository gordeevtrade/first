using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class Anagrams
    {
        public string ReverseWord(string word)
        {
            char[] firstBox;
            char[] secondBox;
            string revers_word;

            if (word != null)
            {
                firstBox = word.ToCharArray();
                secondBox = new char[firstBox.Length];
                for (int i = firstBox.Length - 1, d = 0; i >= 0; i--, d++)
                {
                    secondBox[d] = firstBox[i];
                }
                revers_word = new string(secondBox);
            }

            else
            {
                return "Null here";
            }
            return revers_word;
        }
    }
}

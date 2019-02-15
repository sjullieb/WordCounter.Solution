using System;
using System.Collections.Generic;
namespace WordCounter.Models
{
  public class RepeatCounter
  {

    private static char[] SplitToArray(string str)
    {
      char[] strArray = (str.ToUpper()).ToCharArray();
      return strArray;
    }

    public static int CountWords(string word, string sentence)
    {
      if ((word.Length == 0) || (sentence.Length == 0))
      {
        return 0;
      }
      char[] arrWord = SplitToArray(word);
      char[] arrSentence = SplitToArray(sentence);

      return -1;
    }

  }
}

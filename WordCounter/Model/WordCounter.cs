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

      int result = 0;
      int matchingLetters = 0;
      for(int i = 0; i < arrSentence.Length; i++)
      {
        if(arrSentence[i] == arrWord[i])
        {
          matchingLetters ++;
        }
      }

      if (matchingLetters == arrWord.Length)
        result++;
      return result;
    }

  }
}

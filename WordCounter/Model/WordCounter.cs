using System;
using System.Collections.Generic;
namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private static char[] punctuationMarks = {'\"', '.', ',', ':', ';', '!', '?', '\'', ')'};

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
      int wordIndex = 0;
      bool startChecking = true;
      bool searchInProgress = false;

      Console.WriteLine("{0}", sentence);
      for(int i = 0; i < arrSentence.Length; i++)
      {
        if ((arrSentence[i] == ' ') || (Array.IndexOf(punctuationMarks, arrSentence[i]) > -1)) // end of the current word in the sentence
        {

          if ((wordIndex == arrWord.Length)) // full word found
          {
            Console.WriteLine("position {0} in {1}", i, sentence);

            result++;
          }
          wordIndex = 0;
          searchInProgress = false;
          startChecking = true;
        }
        else
        {
          if((searchInProgress) || (startChecking))
          {
            if (wordIndex == arrWord.Length) // target word is a beginning of another word
            {
              searchInProgress = false;
              wordIndex = 0;
            }
            else if(arrSentence[i] == arrWord[wordIndex])
             {
               wordIndex++;
               startChecking = false;
               searchInProgress = true;
             }
             else
             {
               searchInProgress = false;
               wordIndex = 0;
             }
          }
          else // in the middle of the word which not matches the target one
          {
            continue;
          }
        }
      }

      if (wordIndex == arrWord.Length)
        result++;
      return result;
    }

  }
}

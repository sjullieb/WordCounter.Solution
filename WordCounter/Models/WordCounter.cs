using System;
using System.Collections.Generic;
namespace WordCounterProject.Models
{
  public class RepeatCounter
  {
    private string Word;
    private string Sentence;
    private int Repeatitions;
    private int Id;

    private static int IdCounter = 0;
    private static List<RepeatCounter> Instances = new List<RepeatCounter>{};
    private static char[] punctuationMarks = {'\"', '.', ',', ':', ';', '!', '?', '\'', ')'};

    public RepeatCounter(string word, string sentence)
    {
      Word = word;
      Sentence = sentence;
      IdCounter++;
      Id = IdCounter;
      Instances.Add(this);
      Repeatitions = CountWords(Word, Sentence);
    }

    public static List<RepeatCounter> GetAll()
    {
      return Instances;
    }

    public string GetWord()
    {
      return Word;
    }

    public string GetSentence()
    {
      return Sentence;
    }

    public int GetRepetiotionsNumber()
    {
      return Repeatitions;
    }

    public int GetId()
    {
      return Id;
    }

    public static RepeatCounter Find(int id)
    {
      foreach(RepeatCounter counter in Instances)
      {
        if(counter.Id == id)
        {
          return counter;
        }
      }
      return null;
    }

    public static void ClearAll()
    {
      Instances.Clear();
    }

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

//      Console.WriteLine("{0}", sentence);
      for(int i = 0; i < arrSentence.Length; i++)
      {
        if ((arrSentence[i] == ' ') || (Array.IndexOf(punctuationMarks, arrSentence[i]) > -1)) // end of the current word in the sentence
        {

          if ((wordIndex == arrWord.Length)) // full word found
          {
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

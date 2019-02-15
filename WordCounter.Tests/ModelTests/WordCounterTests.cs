using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void CountWords_EmptyWord_0()
    {
      string word = "";
      string sentence = "I'm walking to the cathedral.";
      int result = WordCounter.Models.RepeatCounter.CountWords(word, sentence);
      Assert.AreEqual(0, result);
    }
    [TestMethod]
    public void CountWords_EmptySentence_0()
    {
      string word = "cat";
      string sentence = "";
      int result = WordCounter.Models.RepeatCounter.CountWords(word, sentence);
      Assert.AreEqual(0, result);
    }
    [TestMethod]
    public void CountWords_SentenceMatchesWord_1()
    {
      string word = "cat";
      string sentence = "Cat";
      int result = WordCounter.Models.RepeatCounter.CountWords(word, sentence);
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void CountWords_WordAtBeginningOfSentenceWithSpaceAfter_1()
    {
      string word = "cat";
      string sentence = "Cat is fat";
      int result = WordCounter.Models.RepeatCounter.CountWords(word, sentence);
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void CountWords_WordAtBeginningOfSentenceWithPunctuationAfter_1()
    {
      string word = "cat";
      string sentence = "Cat? It is fat";
      int result = WordCounter.Models.RepeatCounter.CountWords(word, sentence);
      Assert.AreEqual(1, result);
    }

  }
}

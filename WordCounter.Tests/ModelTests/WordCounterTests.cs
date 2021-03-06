using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounterProject.Models;

namespace WordCounterProject.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void CountWords_EmptyWord_0()
    {
      string word = "";
      string sentence = "I'm walking to the cathedral.";
      int result = RepeatCounter.CountWords(word, sentence);
      Assert.AreEqual(0, result);
    }
    [TestMethod]
    public void CountWords_EmptySentence_0()
    {
      string word = "cat";
      string sentence = "";
      int result = RepeatCounter.CountWords(word, sentence);
      Assert.AreEqual(0, result);
    }
    [TestMethod]
    public void CountWords_SentenceMatchesWord_1()
    {
      string word = "cat";
      string sentence = "Cat";
      int result = RepeatCounter.CountWords(word, sentence);
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void CountWords_WordAtBeginningOfSentenceWithSpaceAfter_1()
    {
      string word = "cat";
      string sentence = "Cat is fat";
      int result = RepeatCounter.CountWords(word, sentence);
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void CountWords_WordAtBeginningOfSentenceWithPunctuationAfter_1()
    {
      string word = "cat";
      string sentence = "Cat? It is fat";
      int result = RepeatCounter.CountWords(word, sentence);
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void CountWords_WordInTheMiddleOfSentenceWithSpacesBeforeAndAfter_1()
    {
      string word = "cat";
      string sentence = "I have a cat and a dog.";
      int result = RepeatCounter.CountWords(word, sentence);
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void CountWords_WordsWithSpaceBeforeAndPunctuationMarkAfter_1()
    {
      string word = "cat";
      string sentence = "Do you have a cat?";
      int result = RepeatCounter.CountWords(word, sentence);
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void CountWords_2WordsInTheMiddleOfSentence_2()
    {
      string word = "cat";
      string sentence = "I have a cat and another cat.";
      int result = RepeatCounter.CountWords(word, sentence);
      Assert.AreEqual(2, result);
    }
    [TestMethod]
    public void CountWords_WordIsPartOfAnotherWord_0()
    {
      string word = "cat";
      string sentence = "Concatenate this strings.";
      int result = RepeatCounter.CountWords(word, sentence);
      Assert.AreEqual(0, result);
    }
    [TestMethod]
    public void CountWords_WordIsBeginningOfAnotherWord_0()
    {
      string word = "cat";
      string sentence = "I'm walking to the cathedral.";
      int result = RepeatCounter.CountWords(word, sentence);
      Assert.AreEqual(0, result);
    }
    [TestMethod]
    public void CountWords_OpeningRoundBracketBeforeWord_1()
    {
      string word = "cat";
      string sentence = "I have many pets (cat, dog, fish).";
      int result = RepeatCounter.CountWords(word, sentence);
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void CountWords_WordAtTheEndOfSentenceWithSpaceBefore_1()
    {
      string word = "cat";
      string sentence = "I have a cat";
      int result = RepeatCounter.CountWords(word, sentence);
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void CountWords_NonAlphabeticSymbolAfterWord_0()
    {
      string word = "cat";
      string sentence = "cat+dog=fight;";
      int result = RepeatCounter.CountWords(word, sentence);
      Assert.AreEqual(0, result);
    }
    [TestMethod]
    public void CountWords_MoreNonAlphabeticSymbolsAfterWord_0()
    {
      string word = "cat";
      string sentence = "cat1 = new Cat();";
      int result = RepeatCounter.CountWords(word, sentence);
      Assert.AreEqual(0, result);
    }
    [TestMethod]
    public void CountWords_MultipleSingleLetterWords_3()
    {
      string word = "a";
      string sentence = "I have a cat, a god and a fish.";
      int result = RepeatCounter.CountWords(word, sentence);
      Assert.AreEqual(3, result);
    }

  }
}

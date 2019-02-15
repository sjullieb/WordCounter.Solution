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

  }
}

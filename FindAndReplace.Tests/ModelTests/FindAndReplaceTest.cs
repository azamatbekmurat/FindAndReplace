using Microsoft.VisualStudio.TestTools.UnitTesting;
using Replacement.Models;
using System.Collections.Generic;
using System;

namespace Replacement.Tests
{
  [TestClass]
  public class FindNReplaceTest
  {
    [TestMethod]
    public void Is_Value_Found_and_Replaced()
    {
      FindNReplace inputValues = new FindNReplace("Hello world", "world", "universe");
      string newSentece = inputValues.ToReplace();
      Console.WriteLine(newSentece);

      Assert.AreEqual("Hello universe.", newSentece);
    }

  }
}

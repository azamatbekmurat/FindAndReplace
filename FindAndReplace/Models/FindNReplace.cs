using System.Collections.Generic;
using System;

namespace Replacement.Models
{
  public class FindNReplace
  {
    private string _sentence;
    private string _findWord;
    private string _replacementWord;


    public FindNReplace(string Sentence, string WordToReplace, string Replacement)
    {
      _sentence = Sentence;
      _findWord = WordToReplace;
      _replacementWord = Replacement;
    }

    public string ToReplace()
    {
      string newSentece = "";
      char[] delimitChars = { ' ', ',', '.' };
      string[] words = _sentence.Split(delimitChars);

      int counter=0;
      for (var i=0; i < words.Length; i++)
      {
        if (i < words.Length-1)
        {
                if (words[i]==_findWord)
                {
                  newSentece += _replacementWord + " ";
                }
                else
                {
                  newSentece += words[i] + " ";
                }
        }
        else
        {
                if (words[i]==_findWord)
                {
                  newSentece += _replacementWord + ".";
                }
                else
                {
                  newSentece += words[i] + ".";
                }
        }
        counter++;
      }
      return newSentece;
    }

  }
}

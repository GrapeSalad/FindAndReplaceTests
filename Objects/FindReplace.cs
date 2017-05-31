using System;


namespace FindAndReplace
{
  public class FindReplace
  {
    public string FindAndReplace(string sentence, string word, string replacementWord)
    {
      string output = sentence.Replace(word, replacementWord);
      return output;
    }
  }
}

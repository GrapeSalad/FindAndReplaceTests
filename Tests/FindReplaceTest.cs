using Xunit;
using System;


namespace FindAndReplace
{
  public class FindReplaceTest
  {
    [Fact]
    public void FindAndReplaceWholeWordTest()
    {
      string sentence = "Hi my name is David. I pooped in my pants yesterday.";
      string word = "David";
      string replace = "Ethan";
      FindReplace wholeWord = new FindReplace();
      Assert.Equal("Hi my name is Ethan. I pooped in my pants yesterday.", wholeWord.FindAndReplace(sentence, word, replace));
    }
    [Fact]
    public void FindAndReplacePartialTest()
    {
      string sentence = "I am walking my cat to the cathedral.";
      string word = "cat";
      string replace = "parrot";
      FindReplace partialWord = new FindReplace();
      Assert.Equal("I am walking my parrot to the parrothedral.", partialWord.FindAndReplace(sentence, word, replace));
    }

  }
}

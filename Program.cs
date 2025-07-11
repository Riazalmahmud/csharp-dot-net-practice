﻿using System;
using System.Dynamic;
using System.Runtime.InteropServices;
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]

class HelpAttribute : System.Attribute
{

  public readonly string url;

  private string topic;

  public string Topic
  {
    get { return topic; }
    set { topic = value; }
  }
  public HelpAttribute(string url)
  {
    this.url = url;

  }

}
// Apply the attribute to a class
[Help("Information on the class MyClass", Topic = "Class Info")]
class MyClass
{
}

namespace ReflectionTest
{


  class SearchInsertPosition
  {
    public static int LengthOfLastWord(string s)
    {
      if (string.IsNullOrEmpty(s))
      {
        return 0;
      }
      s = s.Trim();
      int lastSpaceIndex = s.LastIndexOf(' ');
      if (lastSpaceIndex == -1)
      {
        return s.Length;
      }
      Console.WriteLine("Last space index: " + (s.Length - lastSpaceIndex - 1));
      return s.Length - lastSpaceIndex - 1;
    }


    static void Main(string[] args)
    {
      string testString = "Hello Riaz ! Hello World";
      int length = LengthOfLastWord(testString);
      Console.WriteLine("Length of last word: " + length);
    }
}
}

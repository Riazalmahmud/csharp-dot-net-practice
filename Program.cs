using System;
using System.Dynamic;
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


  class ReflectionClass
  {

    static string largestCommonPrefix(string[] strs)
    {

      Array.Sort(strs);
      string first = strs[0];
      string last = strs[strs.Length - 1];
      int minLength = Math.Min(first.Length, last.Length);

      for (int i = 0; i < minLength; i++)
      {
        string str1 = first[i].ToString();
        string str2 = last[i].ToString();
        // Debugging output to trace the comparison
        Console.WriteLine($"Comparingstr and {str1}" + $"{str2} at index {i}");
        Console.WriteLine($"Comparing {first[i]} and {last[i]} at index {i}");
        if (first[i] != last[i])
        {
          return first.Substring(0, i);
        }
      }

      return first.Substring(0, minLength);   
    }





    static void Main(string[] args)
    {
      string[] arr = { "geeksforgeeks", "geeks", "geek",
                          "geezer", "geeky" };
      string result = largestCommonPrefix(arr);
      Console.WriteLine("The largest common prefix is: " + result);
    }
  }
}

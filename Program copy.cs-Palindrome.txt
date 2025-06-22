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

    static bool IsPalindrome(int x)
    {

      int temp = x;
      int reversed = 0;

      if (temp <0 || (temp % 10 == 0 && temp != 0))
      {
        return false; // Negative numbers and multiples of 10 (except 0) are not palindromes
      }
      while (temp > 0)
      {
        int digit = temp % 10;
        reversed = reversed * 10 + digit;
        temp /= 10;
      }
      return x == reversed;

   
    }


    static void Main(string[] args)
    {
      if (IsPalindrome(121))
      {
        Console.WriteLine("121 is a palindrome.");
      }
      else
      {
        Console.WriteLine("121 is not a palindrome.");
      }

    }
  }
}

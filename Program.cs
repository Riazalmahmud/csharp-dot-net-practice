using System;
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


  class RemoveDuplicates
  {
    public static int RemoveDuplicatesArr(int[] nums)
    {

      if (nums.Length == 0)
      {
        return 0;
      }
      int numbers = 1;
      for (int i = 1; i < nums.Length; i++)
      {
        if (nums[i] != nums[i - 1])
        {
          nums[numbers] = nums[i];
          numbers++;
        }
      }

      return numbers;
    }



    static void Main(string[] args)
    {
      int result = RemoveDuplicatesArr(new int[] { 1, 1, 2, 2, 2 });
      Console.WriteLine("Number of unique elements: " + result);
    }
  }
}

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


  class SearchInsertPosition
  {
    public static int SearchInsert(int[] nums, int target)
    {
      int left = 0;
      int right = nums.Length - 1;
      while (left <= right)
      {
        int mid = left + (right - left) / 2;
        if (nums[mid] == target)
        {
          return mid; // Target found, return index
        }
        else if (nums[mid] < target)
        {
          left = mid + 1; // Target is in the right half
        }
        else
        {
          right = mid - 1; // Target is in the left half
        }
      }
      // Target not found, return the index where it would be inserted
      return left;
    }


    static void Main(string[] args)
    {

      int result = SearchInsert(new int[] { 1, 3, 5, 6 }, 5);
      Console.WriteLine("Result of SearchInsert: " + result);

    }
  }
}

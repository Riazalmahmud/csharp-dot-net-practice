#define DEBUG
using System;
using System.Diagnostics;


class MyClass
{
  [Conditional("DEBUG")]
  public static void Massage(string msg)
  {
    Console.WriteLine(msg);
  }
}


class Test
{
  static void Function1()
  {
    MyClass.Massage("In function 1");
  }
  static void Function2()
  {
    MyClass.Massage("In function 2");
  }


  public static void Main(string[] args)
  {
    MyClass.Massage("In Main function.");
    Function1();
  }
}
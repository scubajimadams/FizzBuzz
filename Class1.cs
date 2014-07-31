using System;
using clFizzBuzz;

public class Class1
{
	public Class1()
	{
        clFizzBuzz fizz = new clFizzBuzz();
        fizz.Fizz = "TestFizz";
        fizz.Buzz = "TestBuzz";
        fizz.intFizz = 3;
        fizz.intBuzz = 5;
        fizz.RangeStart = 1;
        fizz.RangeEnd = 100;

        fizz.WriteFizzBuzz();
        Console.ReadLine();
	}
}

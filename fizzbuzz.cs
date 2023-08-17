
int number = 15;
string result = DivisbleByThree(number);
public static string DivisbleByThree(int number)
{
  if(number % 3 == O)
  {
    result = "fizz";
  }
  else 
  {
    result = ($"{number} isn't divisble by 3");
  }
}
Console.WriteLine(result);


string result2 = DivisbleByFive(number);
public static string DivisbleByFive(int number);
{
    if(number % 5 == 0)
    {
        result2 = "buzz";
    }
    else
    {
        result2 = ($"{number} isn't divisble by 3");
    }
}
Console.WriteLine(result2);

string result3 = DivisbleByBoth(number);
public static string DivisbleByBoth(int number)
{
  if(number % 3 == 0 && number % 5 == 0)
  {
    result3 = "fizzbuzz";
  }
  else
  {
    result3 = ($"{number} isn't divisible by 3 and 5");
  }
}

Console.WriteLine(result3);


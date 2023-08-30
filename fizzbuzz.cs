
int number = 10;
string result = GetFizzBuzz(number);
Console.WriteLine(result);


string GetFizzBuzz(int number)
{
    string result;

    if (number % 3 == 0 && number % 5 == 0)
    {
        result = "fizzbuzz";
        return result;
    }
    else if (number % 5 == 0)
    {
        result = "buzz";
        return result;
    }

    else if (number % 3 == 0)
    {
        result = "fizz";
        return result;
    }

    else
    {
        result = ($"{number} isn't divisble by three or five");
        return result;
    }



}

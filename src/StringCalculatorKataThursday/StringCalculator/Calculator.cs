using System;

public class Calculator
{
    public int Add(string numbers)
    {
        if (numbers == "")
        {
            return 0;
        }
       
        List<string> values = numbers.Split(',', '\n').ToList();
        int sum = 0;
        foreach (string value in values)
        {
            sum += int.Parse(value);
        }

        return sum;
    }
}


public class Calculator
{
    public int Add(string numbers)
    {
        
       
            return numbers == "" ? 0 :  numbers // "1,2,3,4"
                .Split(',', '\n') // ["1", "2", "3", "4"]
                .Select(int.Parse) // [1, 2, 3, 4]
                .Sum(); // 10
        
        
 
    }
}

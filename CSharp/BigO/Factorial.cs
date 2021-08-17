public class Factorial 
{
    /// O(n!)     Factorial
    /// https://en.wikipedia.org/wiki/Factorial
    public static int Perform(int number)
    {
        return calculate(number);
    }

    private static int calculate(int number)
    {
        if(number == 1)
        {
            return number;
        }
        
        int product = 0;
        for(int i = 0; i < calculate(number - 1); i++)
        {
            product += number;
        }

        return product;
    }
}


/*

5!
5 * 4 * 3 * 2 * 1
(1 + 1 + 1 + 1 + 1) * 4 * 3 * 2 * 1

n!

n * (n - 1) * (n - 2) ...


*/

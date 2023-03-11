class Program
{
    static void Main(string[] args)
    {
        //Find the sum of all multiples of 3 or 5 below 1000

        //Declare variable called result and set it as 0
        int result = 0;

        //Loop through from 1 to 999 with instance i
        for (int i = 1; i < 1000; i++)
        {
            //check if each instance gives a 0 when divided by 3 or 5
            if (((i % 3) == 0) || ((i % 5) == 0))
            {
                //if true take the current instance and add to the result variable
                result += i;
            }
        }

        //write the result into the console
        Console.WriteLine("The answer to Project Euler 1 is..");
        Console.WriteLine(result);
    }
}

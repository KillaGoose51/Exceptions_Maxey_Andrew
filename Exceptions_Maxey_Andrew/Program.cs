namespace Exceptions_Maxey_Andrew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float myFloat = 65.4f;
            float myOtherFloat = 0.0f;
            float result = 0f;
            Random rand = new Random(); int myInt = rand.Next(2, 30);
            //test to see if you input the right message/number
            try
            {
                result = Divide(myFloat, myOtherFloat);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter a number other than zero.");
                
                //tries to catch the result of what u input
                try
                {
                    myOtherFloat = (float)Convert.ToDouble(Console.ReadLine());
                    result = Divide(myFloat, myOtherFloat);
                }
                catch (Exception e2)
                {
                    Console.WriteLine(e2.Message);
                }
                finally
                {
                    Console.WriteLine("Calculations completed with a result of " + result);
                }
                //Checks your age
                try
                {
                    CheckAge(myInt);
                }
                catch
                {
                    Console.WriteLine($"You are {myInt} not old enough!");
                }
            }
        }

        //makes a float object called divide with a parameter of x and y
        static float Divide(float x, float y)

        {

            if (y == 0)
            { 
                // Makes it so u wont get a error if u do 0/0
                throw new DivideByZeroException();
            }
            else

                {
                //prints out x divided by y
                    return x / y;
                }
            }
        static void CheckAge(int age)
        {
            if (age >= 17)
            {

                Console.WriteLine($"You are {age}, you can play mature games!");
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
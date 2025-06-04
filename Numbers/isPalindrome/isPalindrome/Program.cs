namespace isPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
             bool IsPalindrome(int x)
            {

                int rem = 0;
                int sum = 0;
                int newnum = 0;
                newnum = x;
                while (x > 0)
                {
                    rem = x % 10;
                    x = x / 10;
                    sum = sum * 10 + rem;
                }

                if (newnum == sum)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
           
        
    }
    }
}

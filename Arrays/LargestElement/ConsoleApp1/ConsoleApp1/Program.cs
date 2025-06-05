namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] arr = { 1, 5, 9, 5, 10, 5, 6,15,5,13,6 };
            Console.WriteLine("secondLargest number is " + SecondLargest(arr));
        }
        public static int Largest(int[] arr)
        {
            int largest = arr[0];
            int secondLargest = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i]>largest)
                {
                    largest = arr[i];
                }
            }

            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i]!=largest)      //
                {
                   
                        secondLargest = arr[i];
                    
                }
            }
            return secondLargest;

        }
        public static int SecondLargest(int[] arr)
        {
            int lar = arr[0];
            int secondLar = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i]>lar)
                {
                    secondLar = lar;
                    lar = arr[i];
                }
                else if (arr[i]>secondLar)
                {
                    secondLar = arr[i];
                }
            }
            return secondLar;
        }
       
    }
}

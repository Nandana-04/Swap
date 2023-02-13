namespace Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3 ; 
            int b = 4;
            int temp;

            temp = a ;
            a = b ;
            b = temp ;

            Console.WriteLine("After swaping :");
            Console.WriteLine("First number : " + a);
            Console.WriteLine("Second number :" + b);

        }
    }
}
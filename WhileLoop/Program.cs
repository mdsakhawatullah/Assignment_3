namespace WhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("This is from for loop");

            int num = 1;

            while(num !=11)
            {
                Console.WriteLine(num);
                num++;
            }
            Console.WriteLine("This is from while loop");

            int number = 1;

            do 
            {
                Console.WriteLine(number);
                number++;


            } while(number<11);
            Console.WriteLine("This is from do while loop");
        }
    }
}

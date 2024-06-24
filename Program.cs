namespace Lesson3__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 43;
            int res = 5 * 43;


            Console.Write("Число ");
            Console.Write(num1);
            Console.Write(" помножити на ");
            Console.Write(num2);
            Console.Write(" дорівнює ");
            Console.Write(res + "\n");

            Console.WriteLine("Число " + num1 + " помножити на " + num2 + " дорівнює " + res);//контактенація

            Console.WriteLine($"Число {num1*num2} помножити на {num2} дорівнює {res}.");//інтерполяція.


        }
    }
}

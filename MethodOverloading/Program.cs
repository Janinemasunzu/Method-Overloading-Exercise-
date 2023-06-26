namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sum = Methods.Add(4,5);
            Console.WriteLine(sum);

            var answer = Methods.Add(2.4m,4.2m);
            Console.WriteLine(answer);

            var result = Methods.Add(6, 4, true);
            Console.WriteLine(result);
        }
    }
}

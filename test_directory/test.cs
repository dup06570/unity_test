namespace CShap
{
    class Program
    {
        enum Choice
        {
            Rock,
            Scissors,
            Paper
        }
        static void Main(string[] args)
        {
            int a = 100;
            short b = (short)a;
            String input;
            input = Console.ReadLine();
            Console.WriteLine(input);
            int number = int.Parse(input);
            String sample = $"a = {a}";
            Console.WriteLine(sample);
            Console.WriteLine(number);
        }
    }
}
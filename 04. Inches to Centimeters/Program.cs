namespace _04._Inches_to_Centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double centemeters = double.Parse(Console.ReadLine());
            double inches = centemeters * 2.54;
            Console.WriteLine(inches);
        }
    }
}
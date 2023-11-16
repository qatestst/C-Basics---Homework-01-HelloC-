namespace _08._Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dogsNum = int.Parse(Console.ReadLine());
            double catsNum = int.Parse(Console.ReadLine());

            double dogsTotalPrice = dogsNum * 2.5;
            double catsTotalPrice = catsNum * 4;

            double sum = dogsTotalPrice + catsTotalPrice;
            Console.WriteLine(sum + " lv.");


        }
    }
}
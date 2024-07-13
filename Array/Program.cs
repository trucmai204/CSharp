namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var time = DateTime.Now;
            var nextDay = time.AddDays(1);
            Console.WriteLine(nextDay.ToString("dd/MM/yyyy HH:mm:ss"));
            var day = time.AddDays(-1);


        }
    }
}

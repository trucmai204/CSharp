namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var numbers = input.Split(' ').Select(num => int.Parse(num)).ToList();
            //foreach (var number in numbers) 
            //{
            //    Console.WriteLine(number);
            //}
            Console.WriteLine(string.Join("-" , numbers));//taoj chuoiox moi
        }
    }
}

using System.Text;
using System.Linq;

namespace MaxMin
{
    internal class Program
    {
        public class Integer
        {
            public List<int> inter {  get; set; }

            public void Input()
            {
                Console.WriteLine("Nhập các số nguyên: ");
                string input = Console.ReadLine();
                inter = input.Split(' ').Select(int.Parse).ToList();
            }
            public int GetMaxNumber()
            {
                //int max = int.MinValue;
      
                //foreach (var num in inter)
                //{
                //    if (num > max)
                //    {
                //        max = num;
                //    }
                //}
                //return max;

                return inter.OrderByDescending(x => x).FirstOrDefault();
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Integer number = new Integer();
            number.Input();
            
            Console.WriteLine("Số lơn nhất trong dãy số là: " +number.GetMaxNumber());
        }
    }
}

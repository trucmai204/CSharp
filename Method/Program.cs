using System.ComponentModel;

namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //int x = 5;
            //int y=5;
            //Console.WriteLine(Add(x, ref y));

            try
            {
                int x = int.Parse(Console.ReadLine());
                double n = 10 / x;
                Console.WriteLine(n);
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.ToString());
            }
        }

        //public static int Add(int x, ref int y) //tên method bđ bằng 1 đọng từ, có danh sách các tham số(gọi theo đúng thứ tự)
        //{
        //    x = 100;
        //    y = 200;
        //    return x + y; 
        //}
        //public void LocalMethod() //
        //{

        //}
    }
}

using Microsoft.VisualBasic.FileIO;

namespace Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;

            //if (x == 0)
            //{
            //    Console.WriteLine("x=0");
            //}
            //else 
            //{
            //    Console.WriteLine("x>0");
            //}

            //string gender = (x == 0) ? "male" : "female";//toán tư 3 ngoi

            switch (x)
            {
                case 0:
                    Console.WriteLine("x==0");
                    break;
                case 1:
                    Console.WriteLine("x==1");
                    break;
                default:
                    Console.WriteLine($"x={x}");
                    break;
            }

            //for (int i = 0; i < args.Length; i++) 
            //{
            //    Console.WriteLine(args[i]);
            //}

            //int i =0;
            //while (i <= 0) 
            //{ 
            //    i++;//in ra i trước r mới cộng 
            //    Console.WriteLine(i.ToString());
            //}
            // do while: thuc hienj trước kiemr tra sau

            //foreach (var x in args) // duyệt từng thành phần trong mảng, biến để dùng trong vòng lặp ko nhất thiết là mảng
            //{
            //    Console.WriteLine(x);
            //}



        }
    }
}

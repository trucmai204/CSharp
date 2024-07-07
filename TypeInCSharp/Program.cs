namespace TypeInCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    int a = 3;
            //    System.Console.WriteLine(a.ToString());//System là không gian tên chứa các lớp cơ bản của .NET Framework. 
            // bool là đại diện (tương đương) với System.Boolean(kiểu này ít sử dụng)
            string s, b, q;// khai báo chuỗi trong ""
            s = Console.ReadLine();
            b = @"uegfwiego\n wegrwi\r";// thêm ký tự @ thì mọi hoạt động bên trong chuỗi sẽ không thực hiện
            q = $"fgyuweyfi {DateTime.Now}";// $ có thể nhúng các biến, biểu thức 
            Console.WriteLine(q);
        }
    }
}

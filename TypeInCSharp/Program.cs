using System.Text;

namespace TypeInCSharp
{
    internal class Program
    {
        int? x; // x có giá trị và có thể bị null
        static void Main(string[] args)
        {
            //    int a = 3;
            //    System.Console.WriteLine(a.ToString());//System là không gian tên chứa các lớp cơ bản của .NET Framework. 
            // bool là đại diện (tương đương) với System.Boolean(kiểu này ít sử dụng)

            /** String
            string s, b, q;// khai báo chuỗi trong ""
            s = Console.ReadLine();
            b = @"uegfwiego\n wegrwi\r";// interpolation string, thêm ký tự @ thì mọi hoạt động bên trong chuỗi sẽ không thực hiện
            q = $"fgyuweyfi {DateTime.Now}";// $ có thể nhúng các biến, biểu thức 
            
            // sử dụng stringbuilder tối ưu hóa hơn phép cộng chuỗi
            StringBuilder sb = new StringBuilder();//
            sb = sb.Append(s);
            sb = sb.Append(b);
            sb = sb.Append(q);// stringbuilder sẽ chuyển string thành các công lệnh cụ thể để tối ưu hiệu năng

            string m = sb.ToString();

            Console.WriteLine(m);*/

            //Dynamic: bỏ qua bước kiểm tra trình dịch

            //var x = 10;//dựa vào dữ liệu nhập thì nó sẽ tự xác định kiểu dữ liệu tương ứng

            //int? y = 0;
            //y.HasValue.ToString();// hasvalue sẽ kireemr tra xem biến có tồn tại giá trị nào hay không
            //Console.WriteLine("abcdfghjk".ToLower());// chuỗi có thể coi là 1 hằng (object)

            string qq = "hetiu";
            qq = qq.Replace("het", "con");
            Console.WriteLine(qq);
        }
    }
}

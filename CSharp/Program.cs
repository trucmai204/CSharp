using System.ComponentModel.Design;
using System.Text;

namespace CSharp
{
    public class Program
    {
        public class Fraction
        {
            public int Numerator {  get; set; } // get, set giới hạn quyền truy cập
            public int Denominator {  get; set; }

            public void Input() // hàm void thể hiện hèn đụng, ko trẻ vè két quả gì hết
            {
                Console.Write("Nhập tử số: ");
                Numerator = int.Parse(Console.ReadLine());
                Console.WriteLine("Tử số là: " + Numerator);

                Console.Write("Nhập mẫu số: ");
                Denominator = int.Parse(Console.ReadLine());
                Console.WriteLine("Mẫu số là: " + Denominator);
                Console.WriteLine($"Phân số :  {Numerator}/{Denominator}"); // $ hiện thì nhìu giá trị oke la khong
            }
            public Fraction Simplify()
            {
                Fraction result = new Fraction();
                int gcd = GetGreatestCommonDivisor(Numerator, Denominator);
                result.Numerator = Numerator / gcd;
                result.Denominator = Denominator / gcd;
                return result; 
            }
           
        }
        public static int GetGreatestCommonDivisor(int number1, int number2) // tên Hàm trả về Giá trị đặt là Get....
        { // đặt tên biến có nghĩa
          //while (b != 0) 
          //{
          //    int t = b;
          //    b = a % b;
          //    a = t;
          //}
          //return a;
            for (int i = number1; i >= 1; i--)
            {
                if (number1 % i == 0 && number2 % i == 0)
                {
                    return i;
                }
            }
            return 1;
        }
        public Fraction GetTotalOf(Fraction frac1, Fraction frac2)
        {
            Fraction result = new Fraction();
            result.Numerator = frac1.Numerator * frac2.Denominator + frac1.Denominator * frac2.Numerator;
            result.Denominator = frac1.Denominator * frac2.Denominator;
            
            return result.Simplify();
        }

        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;// mã hóa sang hỗ trợ tiếng việt

            Fraction fraction = new Fraction(); 
            Fraction fraction2 = new Fraction();

            fraction.Input();
            fraction2.Input();

            Fraction result = GetTotalOf(fraction, fraction2);
            if (result.Denominator == 1)
            {
                Console.WriteLine("Kết quả là: " + result.Numerator);
            }
            else if (result.Denominator == -1)
            {
                result.Numerator *= -1;
                Console.WriteLine("Kết quả là: " + result.Numerator + "/" + result.Denominator);
            }
            else
            {
                Console.WriteLine("Kết quả là: " + result.Numerator + "/" + result.Denominator);
            }


        }
    }
}

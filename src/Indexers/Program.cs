using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<int, string, string> persons = new Tuple<int, string, string>(1, "ff", "ddd");
            //class demo
            //Human humanA = new Human();
            //Human humanB = new Human("Jeff", 30);
            //Fraction fraction1 = Assign(1, 2), fraction2 = Assign(3, 4);
            //DisplayFraction(fraction1);
            //DisplayFraction(fraction2);
            //Fraction fraction3 = PlusFraction(fraction1, fraction2);
            //DisplayFraction(MinimalisticFractions(fraction3));
            //Fraction[] array =
            //{
            //    Assign(1,2), Assign(2,3), Assign(3,4), Assign(4,5)
            //};
            //Fraction total = Assign(0, 1);
            //for (int i = 0; i < 4; i++)
            //{
            //    DisplayFraction(array[i]);
            //    total = PlusFraction(total, array[i]);
            //}
            //DisplayFraction(MinimalisticFractions(total));
            //Console.Write("Enter number of elements in array: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] array = new int[100];
            //EnterAnArray(array, n);
            //ExportArray(array, n);
            //FindPriceNumbers(array, n);
            //SortAnArray();
            //SortBakest();
            //var total = CalculateSumEvenNumbers();
            //Console.WriteLine(total);
            //Exception_Demo();
            //Yield_Demo();
            //Goto_Demo();
            //Ref_Foreach_Demo();
            //Foreach_Demo();
            //Do_While_Demo();
            //While_Demo();
            //Switch_Demo();
            //If_Demo();
            //ArrayDemo();
            //Indexers();
            Console.ReadKey();
        }

        static void SolveTheEquation()
        {
            int a = EnterANumber();
            int b = EnterANumber();
            int c = EnterANumber();
            double delta = b * b - 4 * a * c; // delta
            string result = "";
            result = delta < 0 ? "Phuong trinh vo nghiem" :
                (
                    delta == 0 ? "Nghiem Kep: " + ((-b) / (2 * a)).ToString() :
                    string.Format("2 Nghiem X1 ={0} X2={1}", (-b - Math.Sqrt(delta)) / (2 * a), (-b + Math.Sqrt(delta)) / (2 * a))
                );
            Console.WriteLine(result);
            Console.ReadKey();
        }


        //Indexers
        static void Indexers()
        {
            Employee emp = new Employee()
            {
                EmployeeId = 1,

                FirstName = "John",

                LastName = "Doe"
            };
            emp.Roles[1] = "Dev";
            emp.Roles[3] = "SA";
            for (int i = 1; i <= 3; ++i)
            {
                try
                {
                    Console.WriteLine($"Project {i}: role is {emp.Roles[i]}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        //Array
        static void ArrayDemo()
        {
            int[][] array =
            {
                new int[] {2,4,5,3,8},
                new int[] {5,7,8,2,3,9,10,11,23}
            };
            for (int i = 0; i < array.Length; ++i)
            {
                for (int j = 0; j < array[i].Length; ++j)
                {
                    Console.Write($"{array[i][j]} ");
                }
                Console.WriteLine();
            }
        }

        //if statements
        static void If_Demo() {
            var number = EnterANumber();
            Console.WriteLine(number);
            if (number % 2 == 0)
            {
                Console.WriteLine($"{ number} is Even number");
            }
            else
            {
                Console.WriteLine($"{ number} is Odd number");
            }
        }
        
        //switch statements
        static void Switch_Demo()
        {
            var number = EnterANumber();
            switch (number)
            {
                case 1:
                    Console.WriteLine("Smallest number");
                    break;
                case 2:
                case 3:
                case 5:
                case 7:
                    Console.WriteLine("Prime number");
                    break;
                case 4:
                case 6:
                case 8:
                    Console.WriteLine("Even number");
                    break;
                case 9:
                    Console.WriteLine("Odd number");
                    break;
                default:
                    Console.WriteLine("Not in the range");
                    break;
            }
        }

        //for statements 
        static void For_Demo()
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is an even Number");
                }
                else
                {
                    Console.WriteLine($"{i} is an odd number");
                }
            }
        }


        //while statements
        static void While_Demo()
        {
            int i = 0;
            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is an even number");
                }
                else
                {
                    Console.WriteLine($"{i} is an odd number");
                }
                i++;
            }
        }

        //do while statements
        static void Do_While_Demo()
        {
            int i = 0;
            do
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is an even number");
                }
                else
                {
                    Console.WriteLine($"{i} is an odd number");
                }
                i++;
            } while (i <= 10);
        }

        //foreach statements
        static void Foreach_Demo()
        {
            string[] langueges = { "Java", "C#", "Python", "C++", "Javascript" };
            //foreach (var lang in langueges)
            //{
            //    Console.WriteLine(lang);
            //}

            var emunator = langueges.GetEnumerator();
            while (emunator.MoveNext())
            {
                Console.WriteLine(emunator.Current);
            }
        }

        //ref statements 
        static void Ref_Foreach_Demo()
        {
            Span<int> arr = stackalloc int[] { 1, 1, 2, 3, 5, 8 };
            foreach (ref int n in arr)
            {
                n *= 2;
            }

            foreach (ref readonly var n in arr)
            {
                Console.WriteLine(n);
            }
        }

        //break statements 
        static void Break_Demo()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
                if(i == 5)
                {
                    break;
                }
            }
        }

        //continue statements 
        static void Continue_Demo()
        {
            for (int i = 0; i <= 10; i++)
            {
                if(i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }


        //gogo statements 
        static void Goto_Demo()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                {
                    goto printmessage;
                }
            }
        printmessage:
            Console.WriteLine("The goto statement is executed");
        }
        //fibonacci statements 
        static int Fibonacci(int n)
        {
            if(n > 1)
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            else
                return n;
        }

        //fibonacci async 
        static IEnumerable<int> FibonacciAsync(int n)
        {
            if (n > 1)
                yield return Fibonacci(n - 1) + Fibonacci(n - 2);
            else
                yield return n;
        }

        //yield statements
        static void Yield_Demo()
        {
            {
                IEnumerable<int> GetNumbers()
                {
                    var list = new List<int>();
                    for (int i = 1; i <= 100; i++)
                    {
                        list.Add(i);
                    }
                    return list;
                }
                var numbers = GetNumbers().Take(5);
                Console.WriteLine(string.Join(",", numbers));
            }
            {
                IEnumerable<int> GetNumbers()
                {
                    for (int i = 1; i <= 100; ++i)
                    {
                        yield return i;
                    }
                }

                var numbers = GetNumbers().Take(5);
                Console.WriteLine(string.Join(",", numbers));
            }

            {
                IEnumerable<int> GetNumbers()
                {
                    for (int i = 1; i <= 100; ++i)
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine($"Produced: {i}");
                        yield return i;
                    }
                }

                foreach (var i in GetNumbers().Take(5))
                {
                    Console.WriteLine($"Consumed: {i}");
                }
            }
        }

        //function that throws 
        static void FunctionThatThrows(object o)
        {
            if (o is null)
                throw new ArgumentNullException(nameof(o));
            if (!(o is string))
                throw new ArgumentNullException("A string is expected");
        }

        //exception demo 
        static void Exception_Demo()
        {
            try
            {
                Console.WriteLine("executing");
                FunctionThatThrows(42);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine($"Null argument: {e.Message}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Wrong argument: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                Console.WriteLine("done");
            }
        }

        //Bai 1 Tinh Tong Cac so chan

        static int CalculateSumEvenNumbers()
        {
            int[] array = new int[] { 7, 1, 2, 4, 8, 9, 5 };
            int n = array.Length, total = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] % 2 == 0)
                {
                    total += array[i];
                }
            }
            return total;
        }


        // Bai 2: Tim so nguyen to 
        static void FindPriceNumbers(int[] array, int n)
        {
            for (int i = 0; i < n; i++)
            {
                int number = array[i];
                int pin = 0;
                if (number <= 1) pin = 0;
                else if (number == 2 || number == 3 || number == 5) pin = 1;
                else if (number % 2 == 0) pin = 0;
                else
                {
                    pin = 1;
                    for (int j = 3; j <= number / 2; j++)
                    {
                        if (number % j == 0)
                        {
                            pin = 0;
                            break;
                        }
                    }
                }
                if (pin == 1) Console.Write(number);
            }
        }
        //Bai 3: Bai toan so dao nguoc
        static void FindReverseNumber()
        {
            for (int i = 1; i < 10000; i++)
            {
                int number = i;
                int reverseNumber = 0;
                for (int j = number; j != 0; j = j / 10)
                {
                    reverseNumber = reverseNumber * 10 + i % 10;
                }
                if (number == reverseNumber) Console.WriteLine(number);
            }
        }

        // Bai 4: Sap xep
        static void SortAnArray()
        {
            int[] array = { 7, 5, 6, 2, 8, 3, 9 };
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        //Bai 5: Bai toan cai gio
        static void SortBakest()
        {
            int[] array = { 7, 5, 6, 2, 3, 8, 9, 4, 4, 3, 3, 2, 8, 6 };
            int n = array.Length;
            int[] basket = new int[10];
            // sort into basket
            for (int i = 0; i < n; i++)
            {
                basket[array[i]]++;
            }
            // Pour out to display
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < basket[i]; j++)
                {
                    Console.WriteLine(i);
                }
            }
        }

        //Tinh Tong
        static int CalculateSum(int num1, int num2)
        {
            int total = num1 + num2;
            return total;
        }

        //struct statements
        struct Fraction
        {
            public int Numerator;
            public int Denominator;
        }

        static Fraction Assign(int numerator, int denominator)
        {
            Fraction fraction;
            fraction.Numerator = numerator;
            fraction.Denominator = denominator;
            return fraction;
        }
        static Fraction MinimalisticFractions(Fraction fraction) {
            int numerator = fraction.Numerator;
            int denominator = fraction.Denominator;
            while (numerator != denominator)
            {
                if (numerator > denominator) numerator = numerator - denominator;
                if (denominator > numerator) denominator = denominator - numerator;
            }
            return Assign(fraction.Numerator / numerator, fraction.Denominator / denominator);
        }

        static void DisplayFraction(Fraction fraction)
        {
            Console.WriteLine("{0}/{1}", fraction.Numerator, fraction.Denominator);
        }
        static Fraction PlusFraction(Fraction fraction1, Fraction fraction2)
        {
            return Assign(fraction1.Numerator * fraction2.Denominator + fraction1.Denominator * fraction2.Numerator, fraction1.Denominator * fraction2.Denominator);
        }
        //enter a number from the keyboard
        static int EnterANumber() {
            bool isCorrect = false;
            int number = 0;
            do {
                Console.WriteLine("Enter a positive integer from the keyboard");
                var line = Console.ReadLine();
                if (int.TryParse(line, out number))
                {
                    isCorrect = true;
                }
                else
                {
                    isCorrect = false;
                }
            } while (!isCorrect);
            return number;
        }

        //enter an array from the keyboard
        static void EnterAnArray(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        static void ExportArray(int[] array, int n)
        {
            Console.Write("Display the array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        static void PlusString()
        {
            string str = "";
            for (int i = 1; i < 10; i++)
            {
                str = i.ToString() + " " + str;
            }
            Console.WriteLine(str);
        }

        //Binh phuong gia tri 
        static void BinhPhuong()
        {
            Console.Write("Nhap vao 1 so a =");
            string str = Console.ReadLine();
            int a = int.Parse(str);
            Console.WriteLine("Binh phuong gia tri vua nhap la {0}", a * a);
        }

        //Phuong trinh bac hai
        static void GiaiPhuongTrinh()
        {
            Console.Write("Nhap a =");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b =");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap c =");
            int c = int.Parse(Console.ReadLine());
            double d = b * b - 4 * a * c;
            string kq = "";
            kq = d < 0 ? "Phuong trinh vo nghiem" :
                (
                    d == 0 ? "Nghiem Kep: " + ((-b) / (2 * a)).ToString() :
                    string.Format("2 Nghiem X1 ={0} X2={1}", (-b - Math.Sqrt(d)) / (2 * a), (-b + Math.Sqrt(d)) / (2 * a))
                );
            Console.WriteLine(kq);
            Console.ReadKey();
        }

        //De mo array 
        static void DemoArray()
        {
            int[] a = new int[] { 14, 2, 21, 54, 6, 7 };
            int n = a.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();
            foreach (int so in a)
            {
                Console.Write(so.ToString() + " ");
            }
            Console.WriteLine();
            string str = "abcdefghi1234@#";
            foreach (char c in str)
            {
                Console.WriteLine(c);
            }
        }

        //Handle string 
        static void HandleString()
        {
            string str = "abcdefghijklmnopqrstuvxyz";
            int dd = str.Length;
            Console.WriteLine("chuoi {0} co do dai la {1}", str, dd);
            string s1 = str.Substring(5);
            Console.WriteLine("chuoi con tu vi tri thu 5 la {0}", s1);
            string s2 = str.Substring(5, 3);
            Console.WriteLine("chuoi con tu vi tri thu 5 lay tiep 3 ky tu la {0}", s2);
            string s3 = str.Replace("uv", "12345");
            Console.WriteLine("chuoi thay the \"uv\" boi \"12345\" la {0}", s3);
            Console.WriteLine("Cat chuoi ban dau boi ky tu 'k' va ky tu 't' thi thu duoc mang co:");
            string[] arr = str.Split('k', 't');
            foreach (string s in arr) Console.WriteLine(s);
            int pos = str.IndexOf("klmn");
            Console.WriteLine("Chuoi \"klmn\" xuat hien o vi tri thu {0}", pos);
        }

        //Handle Name Employee
        static void HandleNameEmployee()
        {
            string str = "   Vu   Thi  Quoc    Trung    ";
            str = str.Trim();
            while (str.Contains("  "))
                str = str.Replace("  ", " ");
            string[] arr = str.Split(' ');
            int n = arr.Length - 1;
            string Ten = arr[n];
            for (int i = 0; i < n; i++)
                Ten = Ten + arr[i][0].ToString();
            Console.WriteLine(Ten);
        }


        //khai bao struct
        struct newStruct
        {
            private int num;

            public int n
            {
                get
                {
                    return num;
                }
                set
                {
                    if (value < 50)
                        num = value;
                }
            }
            public void clsMethod()
            {
                Console.WriteLine("\nGia tri duoc luu giu la: {0}\n", num);
            }
        }

        static void KhaiBaoStruct()
        {
            Console.Write("\nKhai bao struct co thuoc tinh, phuong thuc va truong private trong C#:\n");
            Console.Write("----------------------------------------------------------------------\n");
            newStruct myInstance = new newStruct();
            myInstance.n = 15;
            myInstance.clsMethod();
        }

        //Bài tập C#: Tìm phần tử lớn nhất, nhỏ nhất trong mảng: Viết chương trình C# để nhập một mảng, sau đó tìm phần tử lớn nhất và phần tử nhỏ nhất và in kết quả trên màn hình.

        static void TimPhanTuMax()
        {
            int[] arr1 = new int[100];
            int i, mx, mn, n;
            Console.Write("\nTim phan tu lon nhat, phan tu nho nhat trong mang trong C#:\n");
            Console.Write("-----------------------------------------------------------\n");

            Console.Write("Nhap so phan tu can luu giu trong mang: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            mx = arr1[0];
            mn = arr1[0];

            for (i = 1; i < n; i++)
            {
                if (arr1[i] > mx)
                {
                    mx = arr1[i];
                }

                if (arr1[i] < mn)
                {
                    mn = arr1[i];
                }
            }
            Console.Write("Phan tu lon nhat trong mang la: {0}\n", mx);
            Console.Write("Phan tu nho nhat trong mang la: {0}\n\n", mn);
        }
    }
}

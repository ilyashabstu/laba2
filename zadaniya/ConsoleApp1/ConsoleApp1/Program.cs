using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.a
            bool hello = true;
            byte laba = 2;
            sbyte a = 100;
            short myAge = 19;
            ushort b = 15;
            int c = 3334242;
            uint d = 177723;
            long e = 12231254;
            ulong f = 213123312;
            float g = 15.24F;
            double h = 12.3294;
            decimal o = 1005.8M;
            char j = 'j';
            string myName = "ilya";
            object num = 25;
            //1.b
            int thefirst = myAge;
            double thesecond = g;
            short thethird = a;
            double thefourth = e;
            object thefifth = d;
            short thesixth = (short)myAge;
            string theseventh = (string)j.ToString();
            float theeighth = (float)h;
            decimal thenineth = (decimal)f;
            byte thetenth = (byte)myAge;
            //1.c
            object obj = c;//boxing
            int objadd = (int)obj;//unboxing
            //1.d
            var sometext = "Hello owner";
            Console.WriteLine("Тип переменной var: "+sometext.GetType());
            //1.e 
            int? Nullable = null;
            Nullable<int> nullable = null;
            //2.a
            string ex1 = "Петр";
            string ex2 = "Петя";
            int result = String.Compare(ex1, ex2);
            if(result>0)
            {
                Console.WriteLine("Строка ex1 выше по алфавиту, чем ex2");
            }
            else if(result <0)
            {
                Console.WriteLine("Строка ex2 выше по алфавиту, чем ex1");
            }
            else
            {
                Console.WriteLine("Строки идентичны");
            }
            //2.b
            string text1 = "Доброе";
            string text2 = "Утро";
            string text3 = "Союз нерушимых, республик народных";
            string text5 = text1 + " " + text2;
            Console.WriteLine($"Сцепление строк: {text5}");
            string text4 = text3.Substring(0, text3.Length);
            Console.WriteLine($"Скопированная строка {text4}");
            Console.WriteLine("Выделение подстроки " + text2.Substring(2, 2));
            string[] words = text3.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Слова в предложении: ");
            foreach(string i in words)
            {
                Console.WriteLine(i);
            }
            string mod = text4.Insert(4, text1);
            Console.WriteLine("insert метод: " + mod);
            Console.WriteLine("Удаление подстроки "+mod.Remove(4,6));
            //2.c
            string nullstr = null;
            string withouttext = "";
            Console.WriteLine("Строка \"\" " + withouttext.Length + " Строка с null " + text1 + nullstr);
            //2.d
            StringBuilder sb = new StringBuilder("Привет мир");
            Console.WriteLine("Максимальный объем " + sb.Capacity);
            sb.Remove(3, 3);
            sb.Insert(0, "Вставка");
            sb.Insert(sb.Length - 5, "Вставка");
            //3.a
            int[,] massive= { { 1, 2, 3 },{ 6, 7, 8 },{ 9, 10, 11 } };
            for(int i=0;i<3;i++)
            {
                for(int y=0;y<3;y++)
                {
                    Console.Write(massive[i, y]+" ");
                }
                Console.WriteLine();
            }
            //3.b
            string[] masword = { "БГТУ", " - ", " ЛУЧШЕЕ", " ЗАВЕДЕНИЕ В МИРЕ!!!" };
            foreach (string i in masword)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            Console.WriteLine("Длина массива: " + masword.Length);
            Console.WriteLine("Введите позицию, которую надо заменить");
            int choise = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("И значение");
            string input = Console.ReadLine();
            masword[choise] = input;
            foreach (string i in masword)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            //3.c
            double[][] mass=new double[3][];
            mass[0] = new double[2];
            mass[1] = new double[3];
            mass[2] = new double[4];
            int rt=2;
            Console.WriteLine("Введите значения массива ");
            for (int i=0;i<3;i++)
            {
                for(int y=0;y<rt;y++)
                {
                    mass[i][y] = Convert.ToDouble(Console.ReadLine());
                }
                rt++;
            }
            rt = 2;
            Console.WriteLine("Значения полученного массива");
            for (int i = 0; i < 3; i++)
            {
                for (int y = 0; y < rt; y++)
                {
                    Console.Write(mass[i][y]+" ");
                }
                rt++;
                Console.WriteLine();
            }
            var newmass = mass;
            Console.WriteLine("Тип первой неявно типизированной перменной " + newmass.GetType());
            var newmassstr = text1;
            Console.WriteLine("Тип второй неявно типизированной переменной " + newmassstr.GetType());
            (int first, string second, char third, string fourth, ulong fifth) kortez = ( 12, "hello world", 'a', "goodbye", 124124 );
            Console.WriteLine($"Полный вывод кортежа {kortez} и по элементам {kortez.first} {kortez.third} {kortez.fourth}");
            int fir = kortez.first;
            string secon = kortez.second;
            char th = kortez.third;
            string four = kortez.fourth;
            ulong fif = kortez.fifth;
            (int first, string second, char third, string fourth, ulong fifth) kor = (12, "hello world", 'a', "goodbye", 124124);
            Console.WriteLine(kor.Equals(kortez));
            (int, int, int, char) localfun(string arr,int[] numof)
            {
                int summas=0;
                Array.Sort(numof);
                for(int i=0;i<numof.Length;i++)
                {
                    summas += numof[i];
                }
                var resul = (numof[numof.Length-1], numof[0], summas, arr[0]);
                return resul;
            }
            (int, int, int, char) resu = localfun("end", new int[] { 15, 12, 13, 11 });
            Console.WriteLine($"Полученный результат после выполнения функции {resu.Item1} {resu.Item2} {resu.Item3} {resu.Item4}");
        }
    }
}

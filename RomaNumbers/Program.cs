using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomaNumbers
{
    public class Program
    {
        public static int[] Numbers = new int[]{ 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        public static string[] Degrees = new string[] { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M"};
     
        public static string TextRomaNumerals(ref string text, double number, int degree)
        {
            switch (degree)   
            {  
                case 1000:
                    for (int i = 0; i < number; i++)
                    {
                        text = text + "M";
                    }
                    break;
                case 900:
                    for (int i = 0; i < number; i++)
                    {
                        text = text + "CM";
                    }
                    break;
                case 500:
                    for (int i = 0; i < number; i++)
                    {
                        text = text + "D";
                    }
                    break;
                case 400:
                    for (int i = 0; i < number; i++)
                    {
                        text = text + "CD";
                    }
                    break;
                case 100:
                    for (int i = 0; i < number; i++)
                    {
                        text = text + "C";
                    }
                    break;
                case 90:
                    for (int i = 0; i < number; i++)
                    {
                        text = text + "XC";
                    }
                    break;
                case 50:
                    for (int i = 0; i < number; i++)
                    {
                        text = text + "L";
                    }
                    break;
                case 40:
                    for (int i = 0; i < number; i++)
                    {
                        text = text + "XL";
                    }
                    break;
                case 10:
                    for (int i = 0; i < number; i++)
                    {
                        text = text + "X";
                    }
                    break;
                case 9:
                    for (int i = 0; i < number; i++)
                    {
                        text = text + "IX";
                    }
                    break;
                case 5:
                    for (int i = 0; i < number; i++)
                    {
                        text = text + "V";
                    }
                    break;
                case 4:
                    for (int i = 0; i < number; i++)
                    {
                        text = text + "IV";
                    }
                    break;
                case 1:
                    for (int i = 0; i < number; i++)
                    {
                        text = text + "I";
                    }
                    break;
            }
            
            return text;
        }
        public static string Division(double number)
        {
            double value = 0;
            string text="",result="";
          
            
            foreach (var item in Numbers)
            {
                if (number >= item)
                {
                    value = Math.Floor(number / item);
                    result = TextRomaNumerals(ref text, value, item);
                    number = number - (value * item);
                }
            }
      
            return result;
        }
        static void Main(string[] args)
        {
            double number=0;
            string text="";
            Console.Write("1 ile 3999 arasında bir sayı giriniz: ");
            number= Convert.ToDouble(Console.ReadLine());
            if (number > 0 && number < 3999)
            {
                text = Division(number);
                Console.Write("Roma rakamı: " + text);
            }
            else
            {
                text = "1 ile 3999 arasında bir sayı girmediniz";
                Console.Write(text);
            }
            Console.ReadKey();
        }
    }
}

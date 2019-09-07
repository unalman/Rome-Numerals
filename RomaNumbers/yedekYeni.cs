//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace RomaNumbers
//{
//    class yedekYeni
//    {
//        public static int[] Numbers = new int[] { 1000, 500, 100, 50, 10, 5, 1 };
//        public static string[] Degrees = new string[] { "I", "V", "X", "L", "C", "D", "M" };
//        public static List<int> ControllNumbers = new List<int> { 3, 2, 1 };
//        public enum Roma
//        {
//            I = 1,
//            II = 2,
//            III = 3,
//            V = 5,
//            X = 10,
//            L = 50,
//            C = 100,
//            D = 500,
//            M = 1000
//        }
//        public static string TextRomaNumerals(ref string text, double number, int degree)
//        {
//            // V & X kontrolü

//            //if (degree.CompareTo(ControllNumbers) == 0 && number > 1)
//            //{

//            //}
//            if (degree == 1 && number > 3)
//            {
//                //bir üst seviyesinden gelen sayıyı çıkartıp soluna o kadar I koyacağız.

//                for (int i = 0; i < (5 - number); i++)
//                {
//                    text = text + Degrees[0];
//                }
//                text = text + Degrees[1];
//            }
//            else if (degree == 5 && number == 9)
//            {
//                //bir üst seviyesinden gelen sayıyı çıkartıp soluna o kadar I koyacağız.

//                for (int i = 0; i < (10 - number); i++)
//                {
//                    text = text + Degrees[0];
//                }
//                text = text + Degrees[2];
//            }
//            else
//            {
//                switch (degree)
//                {
//                    case 1000:
//                        for (int i = 0; i < number; i++)
//                        {
//                            text = text + "M";
//                        }
//                        break;
//                    case 500:
//                        for (int i = 0; i < number; i++)
//                        {
//                            text = text + "D";
//                        }
//                        break;
//                    case 100:
//                        for (int i = 0; i < number; i++)
//                        {
//                            text = text + "C";
//                        }
//                        break;
//                    case 50:
//                        for (int i = 0; i < number; i++)
//                        {
//                            text = text + "L";
//                        }
//                        break;
//                    case 10:
//                        for (int i = 0; i < number; i++)
//                        {
//                            text = text + "X";
//                        }
//                        break;
//                    case 5:
//                        for (int i = 0; i < number; i++)
//                        {
//                            text = text + "V";
//                        }
//                        break;
//                    case 1:
//                        for (int i = 0; i < number; i++)
//                        {
//                            text = text + "I";
//                        }
//                        break;
//                }
//            }
//            return text;
//        }
//        public static string Division(double number)
//        {
//            double value = 0;
//            string text = "", result = "";


//            foreach (var item in Numbers)
//            {
//                if (number == 9)
//                {
//                    result = TextRomaNumerals(ref text, 9, 5);
//                    break;
//                }
//                else if (number >= item)
//                {
//                    value = Math.Floor(number / item);
//                    result = TextRomaNumerals(ref text, value, item);
//                    number = number - (value * item);
//                }
//            }

//            return result;
//        }
//        static void Main(string[] args)
//        {
//            string a = Division(99);
//            Console.WriteLine(a);
//            Console.ReadKey();
//        }
//    }
//}

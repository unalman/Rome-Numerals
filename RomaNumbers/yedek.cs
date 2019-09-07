//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace RomaNumbers
//{
//    class yedek
//    {
//        public static int[] Numbers = new int[] { 1000, 500, 100, 50, 10, 5, 3, 2, 1 };
//        public static List<int> ControllNumbers = new List<int> { 3, 2, 1 };
//        public static string TextRomaNumerals(ref string text, double number, int degree)
//        {
//            // V & X kontrolü

//            if (degree.CompareTo(ControllNumbers) == 0 && number > 1)
//            {

//            }
//            switch (degree)
//            {
//                case 1000:
//                    for (int i = 0; i < number; i++)
//                    {
//                        text = text + "M";
//                    }
//                    break;
//                case 500:
//                    for (int i = 0; i < number; i++)
//                    {
//                        text = text + "D";
//                    }
//                    break;
//                case 100:
//                    for (int i = 0; i < number; i++)
//                    {
//                        text = text + "C";
//                    }
//                    break;
//                case 50:
//                    for (int i = 0; i < number; i++)
//                    {
//                        text = text + "L";
//                    }
//                    break;
//                case 10:
//                    for (int i = 0; i < number; i++)
//                    {
//                        text = text + "X";
//                    }
//                    break;
//                case 5:
//                    for (int i = 0; i < number; i++)
//                    {
//                        text = text + "V";
//                    }
//                    break;
//                case 3:
//                    for (int i = 0; i < number; i++)
//                    {
//                        text = text + "III";
//                    }
//                    break;
//                case 2:
//                    for (int i = 0; i < number; i++)
//                    {
//                        text = text + "II";
//                    }
//                    break;
//                case 1:
//                    for (int i = 0; i < number; i++)
//                    {
//                        text = text + "I";
//                    }
//                    break;
//            }
//            return text;
//        }
//        public static string Division(double number)
//        {
//            double value = 0;
//            string text = "", result = "";
//            foreach (var item in Numbers)
//            {
//                if (number >= item)
//                {
//                    value = Math.Floor(number / item);
//                    result = TextRomaNumerals(ref text, value, item);
//                    number = number - (value * item);
//                }
//            }
//            //if (number > 1000)
//            //{
//            //    value = Math.Floor(number / 1000);
//            //    result = TextRomaNumerals(ref text, value, 1000);
//            //    extraction = number - (value * 1000);
//            //    if (extraction > 500)
//            //    {
//            //        value = Math.Floor(extraction / 500);
//            //        result = TextRomaNumerals(ref text, value, 500);
//            //        extraction = number - (value * 500);

//            //    }
//            //}
//            return result;
//        }
//    }
//}

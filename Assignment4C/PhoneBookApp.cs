using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment4C
{
    class PhoneBookApp
    {

        private static string[] names = { "xaw",       "Tommy",     "Alan",   "Sergio",    "Adam",     "Pablo" };
        private static string[] phones = { "535-4213", "535-0421", "722-352", "070-3531", "343-2324", "344-2223" };
        private static string[,] phonesNames = new string[6, 2];
        /// <summary>
        ///   0 1
        ///d0{1,2}   petla ktora bierze names[i] i z phones[i]
        ///d1{3,4}   i wsadza to w 
        ///d2{5,6}
        ///d3{7,8}
        ///d4{9,10}
        ///d5{11,12}
        ///
        ///
        /// 
        /// </summary>




        public PhoneBookApp()
        {
            
        }

        public void DisplayList()
        {
            for (int i = 0; i < names.Length; i++)
            {
                string strout = string.Format($"{names[i],-15} {phones[i],-15}");
                Console.WriteLine(strout);
            }
            //int comparison = names[0].CompareTo(names[1]);
            //Console.WriteLine(comparison);
        }
        public void SortByName()
        {
            int pos, i;
            int length = names.Length;
            string temp;

            for(pos=0; pos < length - 1; pos++)
            {
                for (i = 0; i < length - pos - 1; i++)
                {
                    int result = names[i].CompareTo(names[i+1]);
                    
                    if (result == 1) //  if names[i] follows names[pos].
                    {
                        temp = names[i];
                        names[i] = names[i+1];
                        names[i + 1] = temp;
                        // now the phones
                        temp = phones[i];
                        phones[i] = phones[i + 1];
                        phones[i + 1] = temp;
                    }
                }
            }

        }

        public void FillTable()
        {
            for (int dimension = 0; dimension < names.Length; dimension++)
            {
                phonesNames[dimension, 0] = names[dimension];
                phonesNames[dimension, 1] = phones[dimension];
            }

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.Write($"{phonesNames[0, i]} {phonesNames[1, i]} \n");
            //}

        }

        //for (  ; i< 2; i++)
        //        {
        //            valueNames = names[i];
        //            valuePhones = phones[i];
        //            phonesNames[dimension, 0] = valueNames;
        //            phonesNames[dimension, 1] = valuePhones;
        //            Console.Write("i value: " + i);
        //            break;

        //        }






    public void DisplayTable()
        {

            int rows = phonesNames.GetLength(0);
            int cols = phonesNames.GetLength(1);

            for(int row = 0;row < rows; row++)
            {
                Console.WriteLine();
                for(int col = 0; col < cols; col++)
                {
                    Console.Write($"{phonesNames[row, col]}  ");
                }
            }
        }

    }
}

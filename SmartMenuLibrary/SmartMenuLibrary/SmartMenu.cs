﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace SmartMenuLibrary
{
    public class SmartMenu
    {
        public bool LoadMenu(string path)
        {
            string file = File.ReadAllText(path);
            if (file != null)
            {
                return true;
            }
            else
            {
                return false;
            }
            //
            //string[] MenuSpecsArray = file.Split('>');
            //Console.WriteLine(Regex.Replace(MenuSpecsArray[0], "[^A-Z ÆØÅ æøå a-z 0-9]", ""));
            //for (int i = 0; i < MenuSpecsArray.Length; i++)
            //{
            //    string clean = "";
            //    if (i != 1 && i != 0)
            //    {
            //        clean = Regex.Replace(MenuSpecsArray[i], "[^A-Z ÆØÅ æøå a-z 0-9 \r\n]", "");
            //    }
            //    Console.Write(clean + " ");
            //}
            //Console.WriteLine("\n");
            //Console.WriteLine(Regex.Replace(MenuSpecsArray[1], "[^A-Z ÆØÅ æøå a-z 0-9 \r ()]", ""));
        }
        public void Activate()
        {
            //Bindings binding = new Bindings();
            int number = int.Parse(Console.ReadLine());
            string res = "";
            if (number == 0)
            {
               // binding.exit();
            }
            else if (number != 0)
            {
               // res = binding.call(number);
            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}

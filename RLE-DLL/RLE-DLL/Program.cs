﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace RLE_DLL
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Run_Length compresor = new Run_Length();
            Console.WriteLine(compresor.Comprimir("archivos/test.png"));
            Console.WriteLine(compresor.Descomprimir("archivos/test.png.rlex"));
            Console.ReadLine();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C0725030
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Peter Rules the IT Universe!");
            Download();
            Console.ReadLine();
        }
        static void Download()
        {
            Task.Run(() =>
            {
                Thread.Sleep(4000);
                Console.WriteLine("Download Complete!");
            });
        }
    }
}

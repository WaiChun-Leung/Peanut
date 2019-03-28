using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
        //static void Download()
        //{
        //    Task.Run(() =>
        //    {
        //        Thread.Sleep(4000);
        //        Console.WriteLine("Download Complete!"); //will show after 4 seconds
        //    });    //This is asynchronous methods look like
        //}

        static async void Download()
        {
            HttpClient client = new HttpClient();

            var data = await client.GetStringAsync("http://ibm.com");
            //Console.WriteLine("Download Complete!" +data); OR
            Console.WriteLine(data);
            // TO DO: save or store each line of the webpage into an entry
            // in a list
            // look at the Assignment 1
            List mylist = new List();
        }

        //Imaginary external network library

        class Network
        {
            static public Task Download() //Task is class because is uppercase and lightblue
            {
                return Task.Run(() => Thread.Sleep(4000));
            }
        }
    }
}
//Watch video on lynda.com the C# language
﻿
using System;
using System.Collections.Generic;

namespace CourseNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Dictionary<string, string> cookies = new Dictionary<string, string>();
                cookies["user"] = "Maria";
                cookies["email"] = "marial@gmail.com";
                cookies["phone"] = "99712234";
                cookies["phone"] = "28389122"; // overrides

                Console.WriteLine(cookies["email"]);
                Console.WriteLine(cookies["phone"]);

                cookies.Remove("email");

                if (cookies.ContainsKey("email"))
                {
                    Console.WriteLine(cookies["email"]);
                }
                else
                {
                    Console.WriteLine("There is no 'email' key");
                }

                Console.WriteLine($"Size: {cookies.Count}");

                Console.WriteLine("All Cookies:");
                foreach (KeyValuePair<string, string> item in cookies)
                {
                    Console.WriteLine($"{item.Key} : {item.Value}");
                }
            }
			catch (Exception ex)
			{
                Console.WriteLine(ex.Message);
			}
        }
    }
}

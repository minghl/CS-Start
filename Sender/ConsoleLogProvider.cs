﻿using System;
namespace LogServices
{
	public class ConsoleLogProvider:ILogProvider
	{


        public void LogError(string msg)
        {
            Console.WriteLine($"Error:{msg}");
        }

        public void LogInfo(string msg)
        {
            Console.WriteLine($"Info:{msg}");
        }
    }
}


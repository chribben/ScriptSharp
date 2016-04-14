using System;
using ScriptSharp.ScriptEngine;
using Microsoft.Owin.Hosting;

namespace ScriptSharp.Repl
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9000/"; 

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                while (true)
                {
                    var str = Console.ReadLine();
                    Console.WriteLine(CSharpScriptEngine.Execute(str));
                }
            }
        }
    }
}

using System;
using Newtonsoft.Json.Linq;

namespace JSONDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = "{\"key\": \"test\", \"key2\": \"test2\"}";
            JObject jsonObject = JObject.Parse(json);

            
            Console.WriteLine("Hello World!");

            foreach(var kp in jsonObject)
            {
                var key = kp.Key;
                var value = kp.Value;
                Console.WriteLine($"{key}: {value}");
            }

            Console.ReadLine();
        }
    }
}

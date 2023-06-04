using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPatternQuery
{
    class program
    {
        static void Main()
        {

            Login login = new Login
            {
                Email = "test",
                Password = "test",
            };


            Console.WriteLine(login.GetType().Name);


            string json_query = QueryFactory.LoginQuery("kazuiscool@gmail.com", "test");
            Console.WriteLine(json_query);

            Console.WriteLine("Register");
            string json_query_2 = QueryFactory.RegisterQuery("kazuiscool@gmail.com", "test");
            Console.WriteLine(json_query_2);


        }
    }
}

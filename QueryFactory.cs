using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPatternQuery
{
    /*
    * Create query in json string format
    */
    public static class QueryFactory
    {

        
        public static string LoginQuery(string email, string password)
        {
            string json_login = JsonConverter.encodeLogin(email, password);
            string json_query = JsonConverter.encodeQuery("Login", json_login);

            return json_query;
        }


        public static string RegisterQuery(string email, string password)
        {
            string json_register = JsonConverter.encodeRegister(email, password);
            string json_query = JsonConverter.encodeQuery("Register", json_register);

            return json_query;
        }

    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPatternQuery
{
    /*
    * Return json string of object
    */
    public static class JsonConverter
    {

        public static string encodeQuery(string queryType, string data)
        {
            Query query = new Query
            {
                QueryType = queryType,
                Data = data,
            };

            return JsonConvert.SerializeObject(query, Formatting.Indented);
        }


        public static string encodeLogin(string email, string password)
        {
            Login login = new Login
            {
                Email = email,
                Password = password,
            };

            return JsonConvert.SerializeObject(login, Formatting.Indented);
        }


        public static string encodeRegister(string email, string password)
        {
            Register register = new Register
            {
                Email = email,
                Password = password,
            };

            return JsonConvert.SerializeObject(register, Formatting.Indented);
        }


        public static object decodeQuery(string json_query)
        {
            Query query = JsonConvert.DeserializeObject<Query>(json_query);
            string json_data = query.Data;

            object decoded_object = null;

            switch (query.QueryType)
            {
                case "Login":
                    decoded_object = JsonConvert.DeserializeObject<Login>(json_data);
                    break;

                case "Register":
                    decoded_object = JsonConvert.DeserializeObject<Register>(json_data);
                    break;
            }

            return decoded_object;
        }


    }




}


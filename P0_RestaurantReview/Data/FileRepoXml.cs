using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Data
{
    public class FileRepoXml
    {
        public static List<Res> Init()
        {
            List<Res> restaurants = new List<Res>(){
                new Res(){name="GinZa Sushi and Ramen Bar", address="2511 Walker", overview="good food good service, the space is cleaned, servers are nice, ramen is the best", contactNumber="123-456-8906", rating="4.5/5"},
                new Res(){name="Sapporo Sushi and Ramen Bar", address="28th street", overview="good food good service, the space is cleaned, servers are nice, ramen is the best", contactNumber="000-456-2000", rating="4.0/5"}
            };
            return restaurants;
        }
        public static List<User> userList()
        {
            List<User> users = new List<User>(){
                new User(){name="Du", gender="female", age=26}
            };
            return users;
        }

        public static void AddRes(List<Res> restaurants){
            string path = "d:\\Revature\\restaurant.xml";
            TextWriter writer = new StreamWriter(path);
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof (List<Res>));
                serializer.Serialize(writer, restaurants);
            }
            finally
            {
                writer.Close();
            }
        }
        public static List<Res> GetRestaurants(){
            string path = "d:\\Revature\\test.xml";
            TextReader reader = new StreamReader(path);
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof (List<Res>));
                var restaurants = (List<Res>) deserializer.Deserialize(reader);
                if(restaurants.Count > 0)
                    return restaurants;
                else
                {
                    return null;
                }
            }
            finally
            {
                reader.Close();
            }
            }

        /*public static List<User> GetUsers(){
            string path = "d:\\Revature\\user.xml";//problem is here
            TextReader reader = new StreamReader(path);
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof (List<User>));
                var users = (List<User>) deserializer.Deserialize(reader);
                if(users.Count > 0)
                    return users;
                else
                {
                    return null;
                }
            }
            finally
            {
                reader.Close();
            }
            }*/
        
    }
}
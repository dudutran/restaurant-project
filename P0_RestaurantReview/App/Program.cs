using System;
using System.Text;  
using System.IO;
using Lib;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace App // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //GetUser();
            Serialize();
            //UsingData.Serialize();
            //UsingData.Deserialize();
        }
        
        public static List<User> GetDetails1()
        {   
            //get input from user
            User user1 = new User();
            Console.WriteLine("What is your name?");
            user1.name = Console.ReadLine();
            Console.WriteLine("Your gender? Press<0> for Male, <1> for Female");
            InputA:
            string gender = Console.ReadLine();
            if (gender == "0") user1.gender = Gender.Male;
            else if (gender == "1") user1.gender = Gender.Female;
            else 
            {
                Console.WriteLine("Wrong input. Please press<0> for Male, <1> for Female");
                goto InputA;
            }
            Console.WriteLine("How old are you?");
            user1.age = Convert.ToInt32(Console.ReadLine());

            //initialize the list of users
            List<User> users = new List<User>(){
                new User(){name=user1.name, gender=user1.gender, age=user1.age}
            };
            //Console.WriteLine(users);
            return users;
        }
        public static void AddUser(List<User> users){

            //store user's input
            FileStream fs = new FileStream("d:\\Revature\\user.xml", FileMode.Append, FileAccess.Write);  
            StreamWriter sw = new StreamWriter(fs);  

            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof (List<User>));
                serializer.Serialize(sw, users);
            }
            finally
            {
                sw.Close();
            }
        }
        
        public static void Serialize(){
            var users = GetDetails1();
            if (users.Count>0){
                AddUser(users);
                System.Console.WriteLine("Data has been stored");
            }
            }
    }
  
}

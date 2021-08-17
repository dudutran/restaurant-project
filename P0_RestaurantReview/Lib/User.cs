using System;

namespace Lib
{
    public class User
    {
        public string name;
        public Gender gender;
        public int age;
        
        public string GetDetails()
        {
            return $"Customer name: {name} \nCustomer Gender is: {gender}, \nCustomer Age: {age}";
        }
        //public List<User> GetDetails1()
        //{
        //    List<User> users = new List<User>(){
        //        new User(){name, gender, age}
        //    };
        //    return users;
        //}
        

    }
    public enum Gender
    {
        Male = 0 ,
        Female
    }
     
    //public class static List<User> userList()
    //    {
    //        //still do not know how to pass the input of user to this List
    //        List<user> users = new List<User>(){
    //            new user(){name, gender, age},
    //            new user(){name, gender, age}
    //        };
    //        return users;
    //    } 
    

}

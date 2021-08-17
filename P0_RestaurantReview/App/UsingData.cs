using System;
using Data;

namespace App
{
    public class UsingData
    {
        public static void Serialize(){
            var restaurant = FileRepoXml.Init();
            if (restaurant.Count>0){
                FileRepoXml.AddRes(restaurant);
                System.Console.WriteLine("Data has been stored");
            }
            }
        public static void Deserialize(){
           var restaurants = FileRepoXml.GetRestaurants();
           System.Console.WriteLine();
           foreach (var restaurant in restaurants)
           {
               System.Console.WriteLine($"Restaurant: {restaurant.name}\nAddress {restaurant.address}\nContact Number: {restaurant.contactNumber}\nOverview: {restaurant.overview}\nWebsite: {restaurant.website}\nWebsite: {restaurant.rating}");
               
           }
        }
        /*public static void Deserialize(){
           var users = FileRepoXml.GetUsers();
           System.Console.WriteLine();
           foreach (var user in users)
           {
               System.Console.WriteLine($"Name: {user.name}\nGender {user.gender}");
               
           }
        }*/
    }
}
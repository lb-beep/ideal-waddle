using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace CS_131_Projects
{
   public class Program
    {
        
        static void Main()
        {
            
            User userObject = new User();
            userObject.UserName = "Luis";

            Console.WriteLine(userObject.UserName);

           
        }
    }

    public class User {

        public string UserName { get; set; }

    }
    public class Roles
    {
        public string myRole { get; set;  }
    }
    public class Images
    {
        public string Pictures { get; set; }
    }
    public class Post
    {
        public string LikedPost { get; set; }
    }
    public class Comments
    {
        public string FavoriteComment { get; set; }
    }
}


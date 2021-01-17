using System;


namespace ArrayList.Classes
{
    public class User : Roles
    {

        
       
        public User()
        {
            this.UserRole = "Admin";
            this.UserId = 5533;
        }            
        public int UserId { get; set; }
        public string Email { get; set; }
    }
}

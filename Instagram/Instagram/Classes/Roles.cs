using System;
namespace ArrayList.Classes
{
    public class Roles : User
    {
        public Roles()
        {
            this.UserId = 3322;
            this.Email = "blank@gmail.com";
        }
        public int AdminId { get; set; }
        public string UserRole { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Others;
using Welcome.ViewModel;

namespace Welcome.Model
{
    public class User
    {
        public string Names { get; set; }
        public string Passwords { get; set; }
        UserRolesEnum Role;

     
      
        public UserRolesEnum RolesEnum
        {
            get { return Role; }
            set { Role = value; }
        }

        public int Id { get; set; }
        public UserRolesEnum UserRole { get; set; }
        public DateTime Expires { get; set; }
    }
}
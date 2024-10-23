using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;

namespace Welcome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.Names = "Sara";
            user1.Passwords = "Pass123";
            user1.RolesEnum = Others.UserRolesEnum.STUDENT;
            UserViewModel userv1 = new UserViewModel(user1);
            UserView uservm1 = new UserView(userv1);
            uservm1.Display();

        }
    }
}
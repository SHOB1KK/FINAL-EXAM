namespace UserLibrary
{
    public class UserManager : IUserActions
    {
        private List<User> users;

        public UserManager()
        {
            users = new List<User>();
        }

        public void CreateUser(string userName, string email, string role)
        {
            User user;
            if (role == "Admin")
            {
                user = new AdminUser(userName, email, role);
            }
            else if (role == "Regular")
            {
                user = new RegularUser(userName, email, role);
            }
            else
            {
                Console.WriteLine("Неизвестная роль, создается пользователь с ролью Regular.");
                user = new RegularUser(userName, email, role);
            }

            users.Add(user);
            Console.WriteLine($"Пользователь с ID {user.UserId} был добавлен.");
        }

        public void DeleteUser(int userId)
        {
            User user = null;
            foreach (var u in users)
            {
                if (u.UserId == userId)
                {
                    user = u;
                    break;
                }
            }

            if (user != null)
            {
                users.Remove(user);
                Console.WriteLine($"Пользователь с ID {userId} был удалён.");
            }
            else
            {
                Console.WriteLine("Пользователь не найден.");
            }
        }

        public void ChangeRole(int userId, string newRole)
        {
            foreach (var user in users)
            {
                if (user.UserId == userId)
                {
                    user.UserRole = newRole;
                    Console.WriteLine($"Роль пользователя с ID {userId} изменена на {newRole}.");
                    return;
                }
            }
            Console.WriteLine("Пользователь не найден.");
        }

        public void DisplayUsers()
        {
            if (users.Count == 0)
            {
                Console.WriteLine("Нет пользователей для отображения.");
            }
            else
            {
                foreach (var user in users)
                {
                    user.DisplayInfo();
                }
            }
        }
    }
}

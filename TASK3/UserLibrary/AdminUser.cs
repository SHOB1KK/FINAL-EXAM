namespace UserLibrary
{
    public class AdminUser : User
    {
        public AdminUser(string userName, string email, string role) : base(userName, email, role) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Администратор: {Name}, Email: {Email}, Роль: {UserRole}, ID: {UserId}");
        }
    }
}

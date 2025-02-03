namespace UserLibrary
{
    public class RegularUser : User
    {
        public RegularUser(string userName, string email, string role) : base(userName, email, role) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Пользователь: {Name}, Email: {Email}, Роль: {UserRole}, ID: {UserId}");
        }
    }
}

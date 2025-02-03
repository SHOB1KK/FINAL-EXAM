namespace UserLibrary
{
    public abstract class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserRole { get; set; }
        public int nextId = 1;

        public User(string name, string email, string userRole)
        {
            UserId = nextId++;
            Name = name;
            Email = email;
            UserRole = userRole;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"UserId: {UserId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"UserRole: {UserRole}");
        }
    }
}

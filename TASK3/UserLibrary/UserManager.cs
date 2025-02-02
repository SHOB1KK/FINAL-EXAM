namespace UserLibrary;

public class UserManager
{
    private List<User> Users;

    public UserManager()
    {
        Users = new List<User>();
    }

    public void AddUser(User user)
    {
        Users.Add(user);
        Console.WriteLine($"User {user} added.");
    }

    public void RemoveUser(User user)
    {
        Users.Remove(user);
        Console.WriteLine($"User {user} removed.");
    }

    public void ChangeUserRole(string username, Role newRole)
    {
        foreach (var item in Users)
        {
            if (item.Name == username)
            {
                Console.WriteLine($"User {username}'s role changed to {newRole.RoleName}.");
            }
            else {
                System.Console.WriteLine($"User: {username} not found!");
            }
        }
    }
}
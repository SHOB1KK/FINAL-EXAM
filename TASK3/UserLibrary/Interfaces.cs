namespace UserLibrary
{
    public interface IUserActions
    {
        void CreateUser(string userName, string email, string role);
        void DeleteUser(int userId);
        void ChangeRole(int userId, string newRole);
        void DisplayUsers();
    }
}

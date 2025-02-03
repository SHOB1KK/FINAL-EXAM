namespace UserLibrary
{
    public class Role
    {
        public string RoleName { get; set; }
        public List<string> Permissions { get; set; }

        public Role(string roleName)
        {
            RoleName = roleName;
            Permissions = new List<string>();
        }

        public List<string> GetPermissions()
        {
            return Permissions;
        }
    }
}

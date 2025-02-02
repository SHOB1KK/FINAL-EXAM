namespace UserLibrary;

public class Role
{
    public string RoleName { get; set; }
    private List<string> permissions;

    public Role(string roleName)
    {
        RoleName = roleName;
        permissions = new List<string>();
    }

    public void AddPermission(string permission)
    {
        if (!permissions.Contains(permission))
        {
            permissions.Add(permission);
        }
    }

    public List<string> GetPermissions()
    {
        return new List<string>(permissions);
    }
}
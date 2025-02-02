namespace UserLibrary;
using UserLibrary;
public abstract class User {
    public int Unique {get;set;}
    public string Name {get;set;}
    public string Email {get;set;}
    public string UserRole {get;set;}
    public User (int unique, string name, string email, string userrole){
        this.Unique = unique;
        this.Name = name;
        this.Email = email;
        this.UserRole = userrole;
    }
    public void DisplayInfo(){
        System.Console.WriteLine($"UserId: {Unique}");
        System.Console.WriteLine($"Name: {Name}");
        System.Console.WriteLine($"Email: {Email}");
        System.Console.WriteLine($"UserRole: {UserRole}");
    }
}
using UserLibrary;

var userManager = new UserManager();

while (true)
{
    Console.WriteLine("Выберите действие:");
    Console.WriteLine("1. Добавить пользователя");
    Console.WriteLine("2. Удалить пользователя");
    Console.WriteLine("3. Изменить роль пользователя");
    Console.WriteLine("4. Показать всех пользователей");
    Console.WriteLine("0. Выход");

    string command = Console.ReadLine();
    switch (command)
    {
        case "1":
            Console.Write("Введите имя пользователя: ");
            string name = Console.ReadLine();
            Console.Write("Введите email: ");
            string email = Console.ReadLine();
            Console.Write("Введите роль: ");
            string role = Console.ReadLine();
            userManager.CreateUser(name, email, role);
            break;

        case "2":
            Console.Write("Введите ID пользователя для удаления: ");
            int deleteUserId = int.Parse(Console.ReadLine());
            userManager.DeleteUser(deleteUserId);
            break;

        case "3":
            Console.Write("Введите ID пользователя для изменения роли: ");
            int changeRoleId = int.Parse(Console.ReadLine());
            Console.Write("Введите новую роль: ");
            string newRole = Console.ReadLine();
            userManager.ChangeRole(changeRoleId, newRole);
            break;

        case "4":
            userManager.DisplayUsers();
            break;

        case "0":
            return;

        default:
            Console.WriteLine("Некорректный ввод. Попробуйте снова.");
            break;
    }
}


using hometask._24._09;

Employee employee = new Employee();
static Employee[] GetEmployees()
{


    Employee employee1 = new()
    {
        id = 1,
        name = "Rufet",
        surname = "Nesibov",
        address = "Qazax",
        email = "rufat@code.edu.az",
        age = 21
    };

    Employee employee2 = new()
    {
        id = 2,
        name = "Nurlan",
        surname = "Musayev",
        address = "Qazax",
        email = "nurlan@code.edu.az",
        age = 21
    };

    Employee employee3 = new()
    {
        id = 3,
        name = "Ramin",
        surname = "Mahmudov",
        address = "Qazax",
        email = "ramin@code.edu.az",
        age = 21
    };


    Employee employee4 = new()
    {
        id = 4,
        name = "Shamil",
        surname = "Ferruxov",
        address = "Qazax",
        email = "shamil@code.edu.az",
        age = 21
    };


    Employee[] employees = { employee1, employee2, employee3, employee4 };

    return employees;
}


static void ShowEmployee(int a)
{
    Employee[] employees = GetEmployees();

    var result = Array.FindAll(employees, x => x.age > a);

    foreach ( var item in result)
    {
        Console.WriteLine(item.name + " " +item.surname);
    }

}
ShowEmployee(20);
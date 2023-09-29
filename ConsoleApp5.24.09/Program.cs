


//using ConsoleApp5._24._09;

//Employee employee1 = new()
//{

//    fullName = "Rufet Nesibov",
//    age = 21,
//    address = "Qazax"
//};

//Employee employee2 = new()
//{

//    fullName = "Nurlan Musayev",
//    age = 21,
//    address = "Qazax"
//};

//Employee employee3 = new()
//{

//    fullName = "Firdovsi Huseynov",
//    age = 19,
//    address = "Qazax"
//};

//Employee[] employees = {employee1, employee2, employee3};

//foreach (var item in employees)
//{
//    Console.WriteLine(item.GetFullData());
//}

//Book book = new Book("Xosrov", "Nizami");

//book.name = "Isgendername";

//book.author = "Nizami Gencevi";


//Console.WriteLine(book.GetData());

//Book book = new(100, "Azerbaycan");

//Book book = new();





//using ConsoleApp5._24._09;
//using ConsoleApp5._24._09.Models;
//using System.ComponentModel.DataAnnotations;

//User user1 = new User
//{
//    Id = 1,
//    fullName = "Rufet Nesibov",
//    age = 21
//};

//User user2 = new User
//{
//    Id = 2,
//    fullName = "Nurlan Musayev",
//    age = 21
//};

//User user3 = new User
//{
//    Id = 3,
//    fullName = "Ramin Mahmudov",
//    age = 21
//};

//User user4 = new User
//{
//    Id = 4,
//    fullName = "Shamil Ferruxov",
//    age = 21
//};


//User[] people= { user1, user2, user3, user4};


//foreach (var item in people)
//{
//    Console.WriteLine(item.fullName);
//}


//foreach (var item in people)
//{
//    if (item.Id == 2)
//    {
//        Console.WriteLine(item.fullName);
//        break;
//    }
//}


//var result = people.FirstOrDefault(m => m.Id > 2);

//Console.WriteLine(result.fullName);var result = people.FirstOrDefault(m => m.Id > 2);

//var result = people.Where(m => m.Id > 2).ToArray();

//foreach (var item in result)
//{
//    Console.WriteLine(item.fullName);
//}

//var result = Array.FindAll(people, m => m.age > 20);

//foreach (var item in result)
//{
//    Console.WriteLine(item.fullName);
//}


//ShowUsers();

//UserService service = new();

//service.ShowUsers();







//using ConsoleApp5._24._09.Models;
//using System.Threading.Channels;

//static void SearcByName(string searchText)
//{
//    Product[] products = GetAllProducts();

//    bool isExist = false;
    
//    foreach (var product in products)
//    {
//        if (product.name.Trim().ToLower().Contains(searchText.Trim().ToLower()))
//        {
//            Console.WriteLine($"{ product.id} - { product.name} - { product.price} - { product.count}");
//            isExist = true;
//        }
//        else
//        {
//            isExist = false;
//        }
//    }

//    if (!isExist)
//    {
//        Console.WriteLine("Not found");
//    }

//}
//Console.WriteLine("Add search text:");

//SearchText: string searchText = Console.ReadLine();

//if(searchText == "")
//{
//    Console.WriteLine("Please add search text");
//    goto SearchText;
//}

//SearcByName(searchText);

//static Product[] GetAllProducts()
//{
//    Product product1 = new Product
//    {
//        id = 1,
//        name = "Iphone 13",
//        price = 1200,
//        count = 3
//    };

//    Product product2 = new Product
//    {
//        id = 2,
//        name = "Samsung s10",
//        price = 1000,
//        count = 4
//    };

//    Product product3 = new Product
//    {
//        id = 3,
//        name = "Xiaomi",
//        price = 400,
//        count = 30
//    };

//    Product product4 = new Product
//    {
//        id = 4,
//        name = "Nokia",
//        price = 300,
//        count = 50
//    };

//    Product[] products = {product1, product2, product3, product4 };

//    return products;

//}
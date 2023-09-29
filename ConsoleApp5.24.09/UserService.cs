//using ConsoleApp5._24._09.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp5._24._09
//{
//    internal class UserService
//    {
//        public void ShowUsers()
//        {

//            var result = GetAllUsers();

//            foreach (var item in result)
//            {
//                Console.WriteLine(item.fullName);
//            }

//        }

       
//        public User[] GetAllUsers()
//        {
//            User user1 = new User
//            {
//                Id = 1,
//                fullName = "Rufet Nesibov",
//                age = 21
//            };

//            User user2 = new User
//            {
//                Id = 2,
//                fullName = "Nurlan Musayev",
//                age = 21
//            };

//            User user3 = new User
//            {
//                Id = 3,
//                fullName = "Ramin Mahmudov",
//                age = 21
//            };

//            User user4 = new User
//            {
//                Id = 4,
//                fullName = "Shamil Ferruxov",
//                age = 21
//            };


//            User[] people = { user1, user2, user3, user4 };

//            return people;
//        }
//    }
//}

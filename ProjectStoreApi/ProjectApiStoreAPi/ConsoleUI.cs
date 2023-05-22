using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProjectStoreApiModels;
using ProjectStoreApiRepository;

namespace ProjectApiStoreAPi
{
    public class ConsoleUI
    {
        private bool isLoggedIn = false;
        private string selectedStore = null;

        public void Run()
        {
            while (true)
            {
                Console.Clear();

                if (!isLoggedIn)
                {
                    Login();
                }
                else
                {
                    SelectStore();
                    break;
                }
            }

            // TODO After store selection, you can proceed with other functionalities
            // TODO such as viewing products and adding them to the cart
        }

        private void Login()
        {
            Console.WriteLine("Welcome to the Store Application!");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Please log in to continue:");
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            // Perform authentication and validation logic
            bool isLoginValid = AuthenticateUser(username, password);

            if (isLoginValid)
            {
                isLoggedIn = true;
                Console.WriteLine("Login successful!");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid username or password. Please try again.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Perform authentication logic and validate credentials
            // Return true if the username and password are valid, false otherwise
            // Let's assume the username is "admin" and the password is "password"
            return username == "admin" && password == "password";
        }

        private void SelectStore()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Store Application!");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Please choose a store location:");
            Console.WriteLine("1. Jacksville Location 1");
            Console.WriteLine("2. Mark Location 2");
            Console.WriteLine("3. Florida Location 3");
            Console.WriteLine("4. Maryland Location 4");
            Console.WriteLine("5. Houston Location 5");
            Console.Write("Enter the number corresponding to your desired store: ");
            string storeInput = Console.ReadLine();

            // Perform input validation and store selection logic
            if (int.TryParse(storeInput, out int storeNumber) && storeNumber >= 1 && storeNumber <= 5)
            {
                // Map store number to store location or ID
                selectedStore = GetStoreLocation(storeNumber);

                Console.WriteLine($"You have selected {selectedStore}.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                SelectStore(); // Retry store selection
            }
        }

        private string GetStoreLocation(int storeNumber)
        {
            // Map the store number to the corresponding store location or ID
            // You can retrieve the store location from your data store or use a predefined mapping
            // Let's assume the store locations are as follows:
            switch (storeNumber)
            {
                case 1:
                    return "Jacksville Location 1";
                case 2:
                    return "Mark Location 2";
                case 3:
                    return "Florida Location 3";
                case 4:
                    return "Maryland Location 4";
                case 5:
                    return "Houston Location 5";
                default:
                    return string.Empty;
            }
        }
    }

    public class StoreService
    {
        public static void Main()
        {
            ConsoleUI consoleUI = new ConsoleUI();
            consoleUI.Run();
        }
    }
}


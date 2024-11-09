using System;
using Boutique.Services; 
using Boutique.Views;
using Boutique.Entities;

namespace Boutique.Views
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Création des services nécessaires
            IClientService clientService = new IClientServiceImpl(); 
            IArticleService articleService = new IArticleServiceImpl();
            IDebtService debtService = new IDebtServiceImpl();
            IPaymentService paymentService = new IPaymentServiceImpl();
            IUserService userService = new IUserServiceImpl();

            // Création des vues avec les services
            ClientView clientView = new ClientView(clientService);
            ArticleView articleView = new ArticleView(articleService);
            DebtView debtView = new DebtView(debtService, clientService);
            PaymentView paymentView = new PaymentView(paymentService, debtService);
            UserView userView = new UserView(userService);

            Console.WriteLine("=== Boutique Management System ===");
            Console.Write("Enter your role (Boutiquier/Admin/Client): ");
            string role = Console.ReadLine().ToLower();

            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                switch (role)
                {
                    case "boutiquier":
                        ShowBoutiquierMenu(clientView, articleView, debtView, paymentView);
                        break;
                    case "admin":
                        ShowAdminMenu(userView, articleView);
                        break;
                    case "client":
                        ShowClientMenu(clientView, debtView);
                        break;
                    default:
                        Console.WriteLine("Invalid role. Please restart the application.");
                        exit = true;
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("Press any key to return to the main menu...");
                    Console.ReadKey();
                }
            }
        }

        private static void ShowBoutiquierMenu(ClientView clientView, ArticleView articleView, DebtView debtView, PaymentView paymentView)
        {
            Console.WriteLine("=== Boutiquier Menu ===");
            Console.WriteLine("1. Creer un Client");
            Console.WriteLine("2. List Clients");
            Console.WriteLine("3. Rechercher un Client par telephone");
            Console.WriteLine("4. Creer une dette pour un Client");
            Console.WriteLine("5. Enregistrer un payment pour une dette");
            Console.WriteLine("6. Liste des dette impayees");
            Console.WriteLine("7. Retour au menu principal");
            Console.Write("Selectionnez une option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    clientView.CreateClient(); // Méthode à implémenter pour créer un client
                    break;
                case "2":
                    clientView.ListClients(); // Méthode pour lister les clients
                    break;
                case "3":
                    clientView.SearchClientByPhone(); // Méthode pour rechercher un client par téléphone
                    break;
                case "4":
                    debtView.CreateDebt(); // Méthode pour créer une dette pour un client
                    break;
                case "5":
                    paymentView.RecordPayment(); // Méthode pour enregistrer un paiement pour une dette
                    break;
                case "6":
                    debtView.ListUnsettledDebts(); // Méthode pour lister les dettes non soldées
                    break;
                case "7":
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }

        private static void ShowAdminMenu(UserView userView, ArticleView articleView)
        {
            Console.WriteLine("=== Admin Menu ===");
            Console.WriteLine("1. Creer un compte utilisateur pour un Client");
            Console.WriteLine("2. Creer un compte utilisateur avec une Role (Boutiquier/Admin)");
            Console.WriteLine("3. Activer/Desactiver un compte utilisateur");
            Console.WriteLine("4. Afficher un compte utilisateur par Status ou Role");
            Console.WriteLine("5. Creer/List Articles");
            Console.WriteLine("6. Update Article Stock");
            Console.WriteLine("7. Archiver les dettes reglees");
            Console.WriteLine("8. Retour au menu principal");
            Console.Write("Selectionnez une option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    userView.CreateAccountForClient(); 
                    break;
                case "2":
                    userView.CreateAccountWithRole(); 
                    break;
                case "3":
                    userView.ToggleUserAccountStatus(); 
                    break;
                case "4":
                    userView.DisplayUserAccounts(); 
                    break;
                case "5":
                    articleView.CreateOrListArticles(); 
                    break;
                case "6":
                    articleView.UpdateArticleStock(); 
                    break;
                case "7":
                    debtView.ArchiveSettledDebts(); 
                    break;
                case "8":
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }

        private static void ShowClientMenu(ClientView clientView, DebtView debtView)
        {
            Console.WriteLine("=== Client Menu ===");
            Console.WriteLine("1. List des dettes non soldées");
            Console.WriteLine("2. Faire une demande de dette");
            Console.WriteLine("3. List de la demande de dette");
            Console.WriteLine("4. Envoyer un rappel pour la demande de dette annulee");
            Console.WriteLine("5. Retour au menu principal");
            Console.Write("Selectionnez une option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    debtView.ListUnsettledDebts(); // Méthode pour lister les dettes non soldées
                    break;
                case "2":
                    debtView.MakeDebtRequest(); // Méthode pour faire une demande de dette
                    break;
                case "3":
                    debtView.ListDebtRequests(); // Méthode pour lister les demandes de dette
                    break;
                case "4":
                    debtView.SendReminderForCancelledRequest(); // Méthode pour envoyer une relance
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    internal class debtView
    {
        internal static void ArchiveSettledDebts()
        {
            throw new NotImplementedException();
        }
    }

    internal class UserView
    {
        private IUserService userService;

        public UserView(IUserService userService)
        {
            this.userService = userService;
        }

        internal void CreateAccountForClient()
        {
            throw new NotImplementedException();
        }

        internal void CreateAccountWithRole()
        {
            throw new NotImplementedException();
        }

        internal void DisplayUserAccounts()
        {
            throw new NotImplementedException();
        }

        internal void ToggleUserAccountStatus()
        {
            throw new NotImplementedException();
        }
    }

    internal class IPaymentServiceImpl : IPaymentService
    {
        public List<Payment> GetAllPayments()
        {
            throw new NotImplementedException();
        }

        public void RecordPayment(Payment payment)
        {
            throw new NotImplementedException();
        }
    }

    internal class IUserServiceImpl : IUserService
    {
        public void ActivateUser(User user)
        {
            throw new NotImplementedException();
        }

        public void CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeactivateUser(User user)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public User GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }

    internal class IArticleServiceImpl : IArticleService
    {
        public void CreateArticle(Article article)
        {
            throw new NotImplementedException();
        }

        public List<Article> GetAllArticles()
        {
            throw new NotImplementedException();
        }

        public List<Article> GetAvailableArticles()
        {
            throw new NotImplementedException();
        }

        public void UpdateArticleStock(Article article, int newQuantity)
        {
            throw new NotImplementedException();
        }
    }

    internal class IClientServiceImpl : IClientService
    {
        public void CreateClient(Client client)
        {
            throw new NotImplementedException();
        }

        public List<Client> FilterClientsWithAccounts(bool hasAccount)
        {
            throw new NotImplementedException();
        }

        public List<Client> GetAllClients()
        {
            throw new NotImplementedException();
        }

        public Client GetClientByPhone(string phone)
        {
            throw new NotImplementedException();
        }

        public void UpdateClient(Client client)
        {
            throw new NotImplementedException();
        }
    }
}























// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

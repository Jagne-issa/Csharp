// using System;
// using System.Collections.Generic;
// using Boutique.Repositories.Impl;
// using Boutique.Services.Impl;
// using Boutique.Entities;
// using Boutique.Repositories;
// using Boutique.Repositories.Impl;
// using Boutique.Services;
// using Boutique.Services.Impl;
// using IDetteRepository = Boutique.Repositories.Impl.IDetteRepository;

// namespace Boutique.Views
// {
//     class Program
//     {
//         private static object detteService;

//         static void Main(string[] args)
//         {
//             // Création des repositories
//             IUserRepository userRepository = new UserRepositoryImpl();
//             IClientsRepository clientRepository = new ClientRepositoryImpl();
//             IArticleRepository articleRepository = new ArticleRepositoryImpl();
//             IDetteRepository detteRepository = new IDettesRepositoryImpl();
//             IPaymentRepository paymentRepository = new PaymentRepositoryImpl();

//             // Création des services
//             IUserService userService = new Boutique.Services.Impl.UserServiceImpl(userRepository);
//             IClientService clientService = new ClientServiceImpl(clientRepository);
//             IArticleService articleService = new ArticleServiceImpl(articleRepository);
//             IDetteService debtService = new DetteServiceImpl(detteRepository);
//             IPaymentService paymentService = new PaymentServiceImpl(paymentRepository);

//             // Test 1 : Créer des utilisateurs
//             Console.WriteLine("==== Ajouter un utilisateur (Admin/Boutiquier) ====");
//             userService.CreateUser("admin@example.com", "adminuser", "password123", "Admin");
//             userService.CreateUser("boutiquier@example.com", "boutiquieruser", "password123", "Boutiquier");

//             var users = userService.GetAllUsers();
//             foreach (var user in users)
//             {
//                 Console.WriteLine($"Utilisateur : {user.Email}, Login : {user.Login}, Rôle : {user.Role}, Actif : {user.IsActive}");
//             }

//             // Test 2 : Créer un client
//             Console.WriteLine("\n==== Ajouter un client ====");
            

//             var clients = clientService.GetAllClients();
//             foreach (var client in clients)
//             {
//                 string accountStatus = client.AssociatedUser != null ? "Avec compte" : "Sans compte";
//                 Console.WriteLine($"Client : {client.Surnom}, Téléphone : {client.Telephone}, Adresse : {client.Adresse}, Statut du compte : {accountStatus}");
//             }

//             // Test 3 : Créer des articles
//             Console.WriteLine("\n==== Ajouter des articles ====");
//             articleService.CreateArticle("Chaise", 10, 15000);
//             articleService.CreateArticle("Table", 5, 30000);

//             var articles = articleService.GetAllArticles();
//             foreach (var article in articles)
//             {
//                 Console.WriteLine($"Article : {article.surnom}, Quantité en stock : {article.QuantityInStock}, Prix : {article.Price}");
//             }

//             // Test 4 : Créer une dette pour un client
//             Console.WriteLine("\n==== Créer une dette ====");
//             var clientToAssignDebt = clientService.FindClientByTelephone("777777777");
//             var articlesToAdd = new List<Article> { new Article("Chaise", 2, 15000) };
//             var dette = DetteService(clientToAssignDebt, DateTime.Now, 30000, 0, 30000, articlesToAdd);

//             Console.WriteLine($"Dette créée : Montant {dette.Amount}, Montant versé {dette.PaidAmount}, Montant restant {dette.RemainingAmount}");

//             // Test 5 : Enregistrer un paiement pour une dette
//             Console.WriteLine("\n==== Enregistrer un paiement ====");
//             paymentService.CreatePayment(dette, 10000);
//             Console.WriteLine($"Après paiement - Dette : Montant versé {dette.PaidAmount}, Montant restant {dette.RemainingAmount}");

//             // // Test 6 : Lister les dettes non soldées pour un client
//             // Console.WriteLine("\n==== Lister les dettes non soldées ====");
//             // var unsolvedDebts = debtService.GetUnsolvedDettes(clientToAssignDebt);
//             // foreach (var d in unsolvedDebts)
//             // {
//             //     Console.WriteLine($"Dette : Montant restant {d.RemainingAmount}, Articles : {string.Join(", ", d.Articles)}");
//             // }

//             // // Test 7 : Admin - Créer un compte utilisateur pour un client sans compte
//             // Console.WriteLine("\n==== Créer un compte utilisateur pour un client sans compte ====");
//             // var clientWithoutAccount = clientService.FindClientByTelephone("777777777");
//             // userService.CreateUserForClient(clientWithoutAccount, "newclient@example.com", "newclient", "newpass");
//             // Console.WriteLine($"Client {clientWithoutAccount.Surnom} a maintenant un compte : {clientWithoutAccount.AssociatedUser?.Email}");

//             // Test 8 : Lister les articles disponibles
//             Console.WriteLine("\n==== Lister les articles disponibles ====");
//             var availableArticles = articleService.GetAvailableArticles();
//             foreach (var availableArticle in availableArticles)
//             {
//                 Console.WriteLine($"Article disponible : {availableArticle.surnom}, Quantité en stock : {availableArticle.QuantityInStock}");
//             }

//             // Pause pour afficher les résultats
//             Console.WriteLine("\nAppuyez sur une touche pour quitter...");
//             Console.ReadKey();
//         }

//         private static Dettes DetteService(object clientToAssignDebt, DateTime now, int v1, int v2, int v3, List<Article> articlesToAdd)
//         {
//             throw new NotImplementedException();
//         }
//     }

//     internal class User : Users
//     {
//         public User(string email, string login, string password, string role) : base(email, login, password, role)
//         {
//         }

//         public string Email { get; set; }
//         public string Login { get; set; }
//         public string Password { get; set; }
//     }

//     internal class PaymentServiceImpl : IPaymentService
//     {
//         private IPaymentRepository paymentRepository;

//         public PaymentServiceImpl(IPaymentRepository paymentRepository)
//         {
//             this.paymentRepository = paymentRepository;
//         }

//         public void CreatePayment(Dettes dette, decimal amount)
//         {
//             throw new NotImplementedException();
//         }

//         public List<Payments> GetPaymentsByDette(Dettes dette)
//         {
//             throw new NotImplementedException();
//         }
//     }

//     internal class DetteServiceImpl : IDetteService
//     {
//         private object debtRepository;

//         public DetteServiceImpl(object debtRepository)
//         {
//             this.debtRepository = debtRepository;
//         }

//         public void CreateDette(string telephone, decimal amount, List<Article> articles)
//         {
//             throw new NotImplementedException();
//         }

//         public List<Dettes> GetUnpaidDettes(string telephone)
//         {
//             throw new NotImplementedException();
//         }

//         public IEnumerable<object> GetUnsolvedDettes(object clientToAssignDebt)
//         {
//             throw new NotImplementedException();
//         }
//     }

//     internal class ArticleServiceImpl : IArticleService
//     {
//         private IArticleRepository articleRepository;

//         public ArticleServiceImpl(IArticleRepository articleRepository)
//         {
//             this.articleRepository = articleRepository;
//         }

//         public void CreateArticle(string name, int quantityInStock, decimal price)
//         {
//             throw new NotImplementedException();
//         }

//         public List<Article> GetAllArticles()
//         {
//             throw new NotImplementedException();
//         }

//         public List<Article> GetAvailableArticles()
//         {
//             throw new NotImplementedException();
//         }

//         public void UpdateStock(string name, int newQuantity)
//         {
//             throw new NotImplementedException();
//         }
//     }

//     internal class IDettesRepositoryImpl : IDetteRepository
//     {
//         public List<Dettes> GetUnpaidDettesByClient(object id)
//         {
//             throw new NotImplementedException();
//         }
//     }
// }

// // nomspace Boutique.Entities
// // {
// //     public class User
// //     {
// //         public string Email { get; set; }
// //         public string Login { get; set; }
// //         public string Password { get; set; }
// //         public string Role { get; set; }
// //         public bool IsActive { get; set; } = true;
// //     }

// //     public class Client
// //     {
// //         public string Surnom { get; set; }
// //         public string Telephone { get; set; }
// //         public string Address { get; set; }
// //         public User AssociatedUser { get; set; }
// //     }

// //     public class Articles
// //     {
// //         public string nom { get; set; }
// //         public int QuantityInStock { get; set; }
// //         public decimal Price { get; set; }

// //         public Articles(string nom, int quantityInStock, decimal price)
// //         {
// //             nom = nom;
// //             QuantityInStock = quantityInStock;
// //             Price = price;
// //         }
// //     }

// //     public class Dettes
// //     {
// //         public decimal Amount { get; set; }
// //         public decimal PaidAmount { get; set; }
// //         public decimal RemainingAmount => Amount - PaidAmount;
// //         public List<Article> Articles { get; set; }
// //     }
// // }

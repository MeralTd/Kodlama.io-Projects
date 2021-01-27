using GameSalesProject.Abstract;
using GameSalesProject.Concrete;
using GameSalesProject.Entities;
using System;

namespace GameSalesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 1,
                FirstName = "Meral",
                LastName = "Taşdemir",
                DateOfBirth = new DateTime(2000, 1, 1),
                NationalityId = "12345678911"
            };

            Customer customer2 = new Customer()
            {
                Id = 2,
                FirstName = "Kadriye Nur",
                LastName = "Cöer",
                DateOfBirth = new DateTime(2001, 1, 1),
                NationalityId = "12345678912"
            };

            Campaign campaign1 = new Campaign()
            {
                Id = 1,
                Name = "Black Friday"
            };

            CustomerManager customerManager = new CustomerManager();
            customerManager.Save(customer1);
            customerManager.CheckIfRealPerson(customer2);

            CampaignManager campaingManager = new CampaignManager();
            campaingManager.Save(campaign1);

            Game game1 = new Game() { Id = 1, GameName = "Dixit", Price = 280 };
            ISaleService sale = new SaleManager();
            sale.Sale(customer1,game1);

        }
    }
}

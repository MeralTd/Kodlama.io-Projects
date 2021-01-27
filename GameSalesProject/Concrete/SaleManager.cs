using GameSalesProject.Abstract;
using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Concrete
{
    public class SaleManager : ISaleService
    {
        public void CampaignSale(Campaign campaign, Game game, Customer customer)
        {
            Console.WriteLine("User "+ customer.FirstName + " buys game "+ game.GameName +" from campaign "+ campaign.Name);
        }

        public void Sale(Customer customer, Game game)
        {
            Console.WriteLine(customer.FirstName + " bought game " +game.GameName);
        }
    }
}

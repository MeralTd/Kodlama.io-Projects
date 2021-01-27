using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Abstract
{
    public interface ISaleService
    {
        void Sale(Customer customer, Game game);
        void CampaignSale(Campaign campaign, Game game, Customer customer);
    }
}

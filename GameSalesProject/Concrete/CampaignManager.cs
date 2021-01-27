using GameSalesProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesProject.Concrete
{
    public class CampaignManager : ICRUDService<Campaign>
    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " deleted");
        }

        public void Save(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " added");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " updated");
        }
    }
}

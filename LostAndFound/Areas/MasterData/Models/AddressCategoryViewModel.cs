using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LostAndFound.Data.Entity.MasterData;

namespace LostAndFound.Areas.MasterData.Models
{
    public class AddressCategoryViewModel
    {
        public string name { get; set; }

        public AddressCategory addressCategorys { get; set; }

    }
}

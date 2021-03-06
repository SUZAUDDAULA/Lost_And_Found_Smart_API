﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.MasterData.MDOtherItems
{
    public class MobilePhoneType:Base
    {
        [Column(TypeName = "NVARCHAR(150)")]
        public string typeName { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string typeNameBn { get; set; }
        [Column(TypeName = "NVARCHAR(450)")]
        public string imagePath { get; set; }
        public int? shortOrder { get; set; }

    }
}

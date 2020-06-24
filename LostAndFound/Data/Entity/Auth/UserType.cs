using System;
using System.Collections.Generic;
using System.Text;

namespace LostAndFound.Data.Entity.Auth
{
    public class UserType:Base
    {
        public string userTypeName { get; set; }
        public int? shortOrder { get; set; }
    }
}

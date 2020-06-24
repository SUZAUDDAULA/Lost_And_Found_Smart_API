using System.ComponentModel.DataAnnotations;

namespace LostAndFound.Data.Entity.Auth
{
    public class LAFModule:Base
    {
        [StringLength(150)]
        public string moduleName { get; set; }
        [StringLength(150)]
        public string moduleNameBN { get; set; }

        public int? shortOrder { get; set; }
        [StringLength(150)]
        public string isTeam { get; set; }
        [StringLength(150)]
        public string imageClass { get; set; }
    }
}

using LostAndFound.Data.Entity.MasterData;
using LostAndFound.Data.Entity.MasterData.ExtendedMasterData;
using System.ComponentModel.DataAnnotations.Schema;

namespace LostAndFound.Data.Entity.LostFound
{
    public class IndentifyInfo:Base
    {
        public int? gDInformationId { get; set; }
        public GDInformation gDInformation { get; set; }
        public int? colorsId { get; set; }
        public Colors colors { get; set; }
        [Column(TypeName = "NVARCHAR(450)")]
        public string identifySign { get; set; }
        [Column(TypeName = "NVARCHAR(150)")]
        public string identifyType { get; set; }
        public int? religionId { get; set; }
        public Religion religion { get; set; }
        [Column(TypeName = "NVARCHAR(5)")]
        public string bloodGroup { get; set; }
        public int? occupationId { get; set; }
        public Occupation occupation { get; set; }
        public int? maritalStatusId { get; set; }
        public MaritalStatus maritalStatus { get; set; }
        [Column(TypeName = "NVARCHAR(250)")]
        public string attachmentPath { get; set; }
        public int? descriptionCircumcisionId { get; set; }

    }
}

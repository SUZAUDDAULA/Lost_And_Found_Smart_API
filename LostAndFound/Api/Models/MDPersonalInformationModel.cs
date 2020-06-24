using LostAndFound.Data.Entity.MasterData;
using LostAndFound.Data.Entity.MasterData.ExtendedMasterData;
using System.Collections.Generic;

namespace LostAndFound.Api.Models
{
    public class MDPersonalInformationModel
    {
        public IEnumerable<Religion> religions { get; set; }
        public IEnumerable<Gender> genders { get; set; }
        public IEnumerable<ReligionCust> religionCusts { get; set; }
        public IEnumerable<MaritalStatus> maritalStatuses { get; set; }
        public IEnumerable<RelationType> relationTypes { get; set; }
        public IEnumerable<Occupation> occupations { get; set; }
        public IEnumerable<Habit> habits { get; set; }
        public IEnumerable<Speech> speeches { get; set; }
        public IEnumerable<NumberType> numberTypes { get; set; }
        public IEnumerable<DeadbodyCondition> deadbodyConditions { get; set; }
    }
}

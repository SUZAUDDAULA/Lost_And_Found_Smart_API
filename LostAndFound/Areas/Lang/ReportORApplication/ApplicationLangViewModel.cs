using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LostAndFound.Areas.Lang.ReportORApplication.Models
{
    public class ApplicationLangViewModel
    {
        // Basic
        public string title { get; set; }
        public string entryFor { get; set; }
        public string entryType { get; set; }
        public string productType { get; set; }
        public string nextBtn { get; set; }

        // Other Person Info

        public string personTitle { get; set; }
        public string documentType { get; set; }
        public string number { get; set; }
        public string mobile { get; set; }

        // Details

        public string detailsTitle { get; set; }
        public string vehiclesType { get; set; }
        public string brandName { get; set; }
        public string model { get; set; }
        public string registrationNo { get; set; }
        public string engineNumber { get; set; }
        public string chassisNo { get; set; }
        public string cc { get; set; }
        public string yearOfMaking { get; set; }
        public string countryOfMaking { get; set; }
        public string metroNo { get; set; }
        public string groupNo { get; set; }

        // Document OR Product 

        public string documentTitle { get; set; }
        public string type { get; set; }
        public string description { get; set; }

        // Man

        public string identifyingInformation { get; set; }
        public string color { get; set; }
        public string file { get; set; }
        public string identifyingMark { get; set; }

        // animal

        public string livestockInformation { get; set; }

        // DetailsOfLostSpaceAndTime

        public string dateTimeTitle { get; set; }
        public string division { get; set; }
        public string distric { get; set; }
        public string thana { get; set; }
        public string village { get; set; }
        public string placeDetails { get; set; }
        public string dateAndTime { get; set; }

    }
}

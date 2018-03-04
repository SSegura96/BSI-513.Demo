using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Model
{
    public partial class Product
    {
        [DataMember]
        [NotMapped]
        public int MonthsAvailable
        {
            get
            {
                DateTime MySellEndDate = SellEndDate == null ? SellStartDate : (DateTime)SellEndDate;
                return (int)((MySellEndDate - SellStartDate).TotalDays / (365.25 / 12));
            }
            set { }
        }
        [DataMember]
        [NotMapped]
        public string ProductModelName { get; set; }

        [DataMember]
        [NotMapped]
        public string ProductCategoryName { get; set; }

        [DataMember]
        [NotMapped]
        public string ProductSubcategoryName { get; set; }


    }
}

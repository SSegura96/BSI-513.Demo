using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Model
{
    public partial class Product
    {
        [NotMapped]
        public int MonthsAvailable { get {
                DateTime MySellEndDate = SellEndDate == null ? SellStartDate : (DateTime) SellEndDate;
                return (int)((MySellEndDate - SellStartDate).TotalDays / (365.25 / 12));
            } }

        [NotMapped]
        public string ProductModelName { get; set; }

        [NotMapped]
        public string ProductCategoryName { get; set; }

        [NotMapped]
        public string ProductSubcategoryName { get; set; }


    }
}

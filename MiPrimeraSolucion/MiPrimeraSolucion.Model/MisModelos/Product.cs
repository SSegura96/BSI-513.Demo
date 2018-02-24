using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraSolucion.Model
{
    public partial class Product
    {
        public int MonthsAvailable { get {
                DateTime MySellEndDate = SellEndDate == null ? SellStartDate : (DateTime) SellEndDate;
                return (int)((MySellEndDate - SellStartDate).TotalDays / (365.25 / 12));
            } }
    }
}

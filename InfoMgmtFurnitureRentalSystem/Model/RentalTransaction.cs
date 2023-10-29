using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoMgmtFurnitureRentalSystem.Model
{
    public class RentalTransaction
    {
        public Employee Employee { get; private set; }

        public Member Member { get; private set; }

        public ICollection<Furniture> RentalItems { get; private set; }
    }
}

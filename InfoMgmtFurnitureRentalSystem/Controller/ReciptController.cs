using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoMgmtFurnitureRentalSystem.Model;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace InfoMgmtFurnitureRentalSystem.Controller
{
    public class ReciptController
    {
        public string fees { get; }
        public int transactionId { get; }
        public IList<Furniture> returnedFurniture { get; }
        public ReciptController(string fees, int transactionId, IList<Furniture> returnControllerFurniture)
        {
            this.fees = fees;
            this.transactionId = transactionId;
            this.returnedFurniture = returnControllerFurniture;
        }
    }
}

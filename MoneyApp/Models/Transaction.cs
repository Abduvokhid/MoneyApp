using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp.Models
{
    public class Transaction
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public int ContactID { get; set; }
        public string ContactName { get; set; }
        public bool Type { get; set; }
        public string TypeName { get; set; }
        public decimal Amount { get; set; }
        public string Note { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

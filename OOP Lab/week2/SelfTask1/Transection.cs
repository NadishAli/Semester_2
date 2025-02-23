using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfTask1
{
    public class Transection
    {
        public string transectionID;
        public string productName;
        public string amount;
        public string date;
        public string time;
        public Transection()
        {
            
        }
        public Transection(Transection id)
        {
            productName = id.productName;
            transectionID=id.transectionID;
            amount=id.amount;
            date=id.date;
            time=id.time;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace lab_38_northwind_api_client.Models
{
    public partial class Customer
    {
        public override string ToString()
        {
            return $"Customer Id: {CustomerId}\nLiving at: {Address}";
        }
    }
}

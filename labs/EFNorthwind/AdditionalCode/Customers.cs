using System;
using System.Collections.Generic;
using System.Text;

namespace EFNorthwind
{
    public partial class Customers
    {
        public override string ToString()
        {
            return $"{CustomerId} - {ContactName} - {City}";
        }
    }
}

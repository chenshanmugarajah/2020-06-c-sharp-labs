using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public interface IMovable //naming convention is interface name starts with I
    {
        string Move();
        string Move(int item);
        
    }
}

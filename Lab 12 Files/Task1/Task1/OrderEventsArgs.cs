using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public class OrderEventArgs : EventArgs
{
    public string Customer { get; }
    public string Product { get; }
    public int Quantity { get; }

    public OrderEventArgs(string customer, string product, int quantity)
        => (Customer, Product, Quantity) = (customer, product, quantity);
}

using System;

public class ShipEventArgs : EventArgs
{
    public string Product { get; }
    public bool Express { get; }

    public ShipEventArgs(string product, bool express)
        => (Product, Express) = (product, express);
}

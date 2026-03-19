using System;

public class TransportManager
{
    private Transport[] transports;

    public TransportManager(Transport[] transports)
    {
        this.transports = transports;
    }

    public Transport GetMostEfficientVehicle()
    {
        if (transports == null || transports.Length == 0)
            return null;

        Transport best = transports[0];

        foreach (var transport in transports)
        {
            if (transport.FuelConsumption < best.FuelConsumption)
                best = transport;
        }

        return best;
    }

    public Transport GetFastestVehicle()
    {
        if (transports == null || transports.Length == 0)
            return null;

        Transport fastest = transports[0];

        foreach (var transport in transports)
        {
            if (transport.MaxSpeed > fastest.MaxSpeed)
                fastest = transport;
        }

        return fastest;
    }

    public void ShowAll()
    {
        foreach (var transport in transports)
            Console.WriteLine(transport);
    }
}

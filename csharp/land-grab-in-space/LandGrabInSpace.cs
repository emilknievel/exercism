using System;

public struct Coord
{
    public Coord(ushort x, ushort y)
    {
        X = x;
        Y = y;
    }

    public ushort X { get; }
    public ushort Y { get; }
}

public struct Plot
{
    public Plot(Coord c1, Coord c2, Coord c3, Coord c4)
    {
        C1 = c1;
        C2 = c2;
        C3 = c3;
        C4 = c4;
    }

    public Coord C1 { get; }
    public Coord C2 { get; }
    public Coord C3 { get; }
    public Coord C4 { get; }
}


public class ClaimsHandler
{
    public void StakeClaim(Plot plot)
    {
        throw new NotImplementedException("Please implement the ClaimsHandler.StakeClaim() method");
    }

    public bool IsClaimStaked(Plot plot)
    {
        throw new NotImplementedException("Please implement the ClaimsHandler.IsClaimStaked() method");
    }

    public bool IsLastClaim(Plot plot)
    {
        throw new NotImplementedException("Please implement the ClaimsHandler.IsLastClaim() method");
    }

    public Plot GetClaimWithLongestSide()
    {
        throw new NotImplementedException("Please implement the ClaimsHandler.GetClaimWithLongestSide() method");
    }
}

using System.Collections.Generic;
using Zamay.Domain;

public class PassStorage
{
    private Dictionary<int, Pass> Passes { get; } = new();

    public void Create(Pass pass)
    {
        Passes.Add(pass.PassNumber, pass);
    }

    public Pass Read(int passNumber)
    {
        return Passes[passNumber];
    }

    public Pass Update(int passNumber, Pass newPass)
    {
        Passes[passNumber] = newPass;
        return Passes[passNumber];
    }

    public bool Delete(int passNumber)
    {
        return Passes.Remove(passNumber);
    }
}
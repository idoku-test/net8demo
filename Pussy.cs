using System.Text.Json.Serialization;

public class Pussy {
    public readonly int Meows;

    [JsonConstructor]
    private Pussy() { }

    public Pussy(int meows)
    {
        this.Meows = meows;
    }
}
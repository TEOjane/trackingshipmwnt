namespace Domain;

public class Cargo
{
    public long Id { get; set; }
    public Carrier Carrier { get; set; }
    public DateTime DepartureTime { get; set; }
    public string DeparturePoint { get; set; }
    public string Destination { get; set; }
    public decimal DeclaredValue { get; set; }
    public double Weight { get; set; }
}
namespace Domain;

public class Goods
{
    public long Id { get; set; }
    public Company Company { get; set; }
    public DateTime DepartureTime { get; set; }
    public string DeparturePoint { get; set; }
    public string Destination { get; set; }
    public decimal DeclaredValue { get; set; }
    public double Weight { get; set; }
}
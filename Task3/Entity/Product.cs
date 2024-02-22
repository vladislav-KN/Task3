namespace Task3.Entity;

public class Product
{
    public Product(int id, string name, Unit unitType, float cost)
    {
        Id = id;
        Name = name;
        UnitType = unitType;
        Cost = cost;
    }
    public int Id {get; set;}
    public string Name {get; set;}
    public Unit UnitType {get; set;}
    public float Cost {get; set;}
}
public enum Unit
{
    Литр,
    Килограмм,
    Штука
}
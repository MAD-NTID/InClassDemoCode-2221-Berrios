public class Vehicle
{
    private string owner;
    private int plateNumber;
    private string plateState;

    public int PlateNumber
    {
        get => plateNumber;
        set => plateNumber = value;
    }

    public string Owner
    {
        get=> owner;
        set => owner = value;
    }

    public string PlateState
    {
        get => plateState;
        set => plateState = value;
    }

    public Vehicle()
    {
        plateState = "N/A";
        plateNumber = 0;
        owner = "N/A";
    }

    public Vehicle(string owner, int plateNumber, string plateState)
    {
        PlateNumber = plateNumber;
        Owner = owner;
        PlateState = plateState;
    }

    public override string ToString()
    {
        return $"Owner:{Owner}\nPlate State:{PlateState}\nPlate Number:{PlateNumber}";
    }
}
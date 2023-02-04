namespace UrbanPlanner;
public class Program
{
    static void Main(string[] args)
    {
        Building FiveOneTwoEigth = new Building("512 8th Avenue");
        FiveOneTwoEigth.Stories = 15;
        FiveOneTwoEigth.Width = 98.27;
        FiveOneTwoEigth.Depth = 47.68;
        FiveOneTwoEigth.Purchase("Michael");
        FiveOneTwoEigth.Construct();

        Building TwoOneSeventh = new Building("21 7th Street");
        TwoOneSeventh.Stories = 7;
        TwoOneSeventh.Width = 42.50;
        TwoOneSeventh.Depth = 37.15;
        TwoOneSeventh.Purchase("Audrey");
        TwoOneSeventh.Construct();

        List<Building> buildings = new List<Building>();
        buildings.Add(FiveOneTwoEigth);
        buildings.Add(TwoOneSeventh);

        foreach (Building building in buildings)
        {
            Console.WriteLine($"{building.Address}------------------");
            Console.WriteLine($"Designed by: {building.Designer}");
            Console.WriteLine($"Constructed on: {building.DateConstructed}");
            Console.WriteLine($"Purchased by: {building.Owner}");
            Console.WriteLine($"{building.Volume} cubic meters of space");
            Console.WriteLine("______________________________");
        }

    }
}
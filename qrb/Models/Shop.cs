namespace qrb.Models;

public class Shop
{
    public string Name { get; set; }
    public string Specialization { get; set; }

    public Shop(string name, string specialization)
    {
        Name = name;
        Specialization = specialization;
    }
}
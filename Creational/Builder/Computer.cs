namespace CreationalPatterns.Creational.Builder;

// Складний об'єкт, який збираємо поетапно.
public class Computer
{
    public string CPU       { get; set; } = "";
    public string GPU       { get; set; } = "";
    public int    RamGB     { get; set; }
    public int    StorageGB { get; set; }
    public string PSU       { get; set; } = "";

    public override string ToString() =>
        $"Computer{{ CPU={CPU}, GPU={GPU}, RAM={RamGB}GB, Storage={StorageGB}GB, PSU={PSU} }}";
}

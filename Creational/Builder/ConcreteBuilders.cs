namespace CreationalPatterns.Creational.Builder;

public class GamingComputerBuilder : IComputerBuilder
{
    private Computer _computer = new();

    public void Reset()      => _computer = new Computer();
    public void SetCpu()     => _computer.CPU = "AMD Ryzen 9 7950X";
    public void SetGpu()     => _computer.GPU = "NVIDIA RTX 4090";
    public void SetRam()     => _computer.RamGB = 64;
    public void SetStorage() => _computer.StorageGB = 2000;
    public void SetPsu()     => _computer.PSU = "1000W Gold";

    public Computer GetResult()
    {
        var result = _computer;
        Reset();
        return result;
    }
}

public class OfficeComputerBuilder : IComputerBuilder
{
    private Computer _computer = new();

    public void Reset()      => _computer = new Computer();
    public void SetCpu()     => _computer.CPU = "Intel Core i5-13400";
    public void SetGpu()     => _computer.GPU = "Integrated UHD 730";
    public void SetRam()     => _computer.RamGB = 16;
    public void SetStorage() => _computer.StorageGB = 512;
    public void SetPsu()     => _computer.PSU = "450W Bronze";

    public Computer GetResult()
    {
        var result = _computer;
        Reset();
        return result;
    }
}

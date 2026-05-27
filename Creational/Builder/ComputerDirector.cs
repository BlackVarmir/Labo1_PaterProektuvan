namespace CreationalPatterns.Creational.Builder;

// Директор інкапсулює порядок кроків.
public class ComputerDirector
{
    public void Construct(IComputerBuilder builder)
    {
        builder.Reset();
        builder.SetCpu();
        builder.SetGpu();
        builder.SetRam();
        builder.SetStorage();
        builder.SetPsu();
    }
}

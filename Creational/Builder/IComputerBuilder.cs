namespace CreationalPatterns.Creational.Builder;

// Інтерфейс будівельника описує кроки складання продукту.
public interface IComputerBuilder
{
    void Reset();
    void SetCpu();
    void SetGpu();
    void SetRam();
    void SetStorage();
    void SetPsu();
    Computer GetResult();
}

namespace AnimalCentre.IO.Contracts
{
    public interface IWriter
    {
        void WriteLine(string message);
        void Flush();
    }
}

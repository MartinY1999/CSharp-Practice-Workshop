namespace DependencyInversion.IO
{
    public interface IReader
    {
        string ReadLine();
        string[] Split(string input);
    }
}

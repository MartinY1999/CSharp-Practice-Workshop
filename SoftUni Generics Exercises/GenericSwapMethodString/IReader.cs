using System.Collections.Generic;

namespace GenericSwapMethodString
{
    public interface IReader
    {
        string ReadString();
        int ReadInt();
        List<int> ReadCommand();
        Box<string> ReadStringBox();
        Box<int> ReadIntBox();
    }
}

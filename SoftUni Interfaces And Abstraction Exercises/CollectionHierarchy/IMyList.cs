using System.Collections.Generic;

namespace CollectionHierarchy
{
    public interface IMyList<T> : IAddRemoveCollection<T>
    {
        IReadOnlyCollection<T> Used { get; }
    }
}

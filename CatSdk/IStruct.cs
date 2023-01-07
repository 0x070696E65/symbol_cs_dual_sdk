using System.Collections.Generic;

namespace CatSdk
{
    public interface IStruct : ISerializer
    {
        public Dictionary<string, string> TypeHints { get; }
    }
}
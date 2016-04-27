namespace Tokiota.Store.Demo.Infrastructure
{
    using System.Collections.Generic;

    public interface ICallResult
    {
        bool Succeeded { get; }
        IEnumerable<string> Errors { get; }
    }
}
namespace Tokiota.Store.Demo.Infrastructure
{
    using System.Collections.Generic;

    public interface IBootstrapper
    {
        IContainer Run(IEnumerable<string> modules);
    }
}

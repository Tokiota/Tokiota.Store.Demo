namespace Tokiota.Store.Demo.Infrastructure
{
    public interface ITracer
    {
        void Write(string line);

        void Error(string line);

        void Warning(string line);

        void Info(string line);

        void Write(string line, params object[] args);

        void Error(string line, params object[] args);

        void Warning(string line, params object[] args);

        void Info(string line, params object[] args);
    }
}

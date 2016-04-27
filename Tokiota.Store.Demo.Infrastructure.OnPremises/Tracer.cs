namespace Tokiota.Store.Demo.Infrastructure.OnPremises
{
    public class Tracer : ITracer
    {
        public const string ErrorCategory = "Error";
        public const string WarningCategory = "Warning";
        public const string InfoCategory = "Info";

        public void Write(string line)
        {
            System.Diagnostics.Trace.WriteLine(line);
        }

        public void Error(string line)
        {
            System.Diagnostics.Trace.WriteLine(line, ErrorCategory);
        }

        public void Warning(string line)
        {
            System.Diagnostics.Trace.WriteLine(line, WarningCategory);
        }

        public void Info(string line)
        {
            System.Diagnostics.Trace.WriteLine(line, InfoCategory);
        }

        public void Write(string line, params object[] args)
        {
            System.Diagnostics.Trace.WriteLine(string.Format(line, args));
        }

        public void Error(string line, params object[] args)
        {
            System.Diagnostics.Trace.WriteLine(string.Format(line, args), ErrorCategory);
        }

        public void Warning(string line, params object[] args)
        {
            System.Diagnostics.Trace.WriteLine(string.Format(line, args), WarningCategory);
        }

        public void Info(string line, params object[] args)
        {
            System.Diagnostics.Trace.WriteLine(string.Format(line, args), InfoCategory);
        }
    }
}

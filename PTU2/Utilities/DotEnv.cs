using System.Linq.Expressions;
using static System.Convert;
namespace The_Prodigal_Son.Utilities
{
    public static class DotEnv
    {
        public static void Load(string filePath)
        {
            if (!File.Exists(filePath))
                return;

            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split(
                    "=",
                    2,
                    StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length != 2)
                    continue;

                Environment.SetEnvironmentVariable(parts[0], parts[1]);
            }
        }

        public static string Fetch(string variable)
        {
            try { string? envar = Environment.GetEnvironmentVariable(variable); return envar; }
            catch { return variable + "not found"; }
        }

        public static ulong FetchLogID()
        {
            var mode = Environment.GetEnvironmentVariable("mode");
            var variable = mode + "Logging";
            try { string envars = Environment.GetEnvironmentVariable(variable); ulong envari = ulong.Parse(envars); return envari; }
            catch { return 0; }
        }

        public static string SetMode(string mode)
        {
            try
            {
                var vars = Environment.GetEnvironmentVariables();
                Environment.SetEnvironmentVariable("mode", mode);
                var vars2 = Environment.GetEnvironmentVariables();
                return "Success! Changed mode to " + mode;
            }

            catch
            {
                return "Unable to change mode.";
            }
        }
    }
}

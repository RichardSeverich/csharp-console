using System;
using System.IO;

namespace SensitiveInformationDatabase.Src.Configurations
{
    internal static class ReadEnv
    {
        private readonly static string FILE_PATH = Path.Combine(Directory.GetCurrentDirectory(), ".env");

        internal static void Load()
        {
            if (!File.Exists(FILE_PATH))
            {
                return;
            }

            foreach (var line in File.ReadAllLines(FILE_PATH))
            {
                var parts = line.Split('=', StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length != 2)
                {
                    continue;
                }

                Environment.SetEnvironmentVariable(parts[0], parts[1]);
            }
        }
    }
}

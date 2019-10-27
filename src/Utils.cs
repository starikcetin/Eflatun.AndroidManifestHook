using System.IO;
using System.Text;

namespace Eflatun.AndroidManifestHook
{
    internal static class Utils
    {
        public static string GetManifestPath(string basePath) {
            var pathBuilder = new StringBuilder(basePath);
            pathBuilder.Append(Path.DirectorySeparatorChar).Append("src");
            pathBuilder.Append(Path.DirectorySeparatorChar).Append("main");
            pathBuilder.Append(Path.DirectorySeparatorChar).Append("AndroidManifest.xml");
            return pathBuilder.ToString();
        }

        public static string ToManifestString(this bool val)
        {
            return val ? "true" : "false";
        }
    }
}

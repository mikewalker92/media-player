namespace MediaPlayer.Desktop.Helpers
{
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;

    public static class AssemblyExtensions
    {
        public static IEnumerable<Assembly> LoadMediaPlayerExtensions(this Assembly assembly)
        {
            if (IsMediaPlayerAssembly(assembly.GetName()))
            {
                yield return assembly;
            }

            foreach (var assemblyName in assembly.GetReferencedAssemblies().Where(IsMediaPlayerAssembly))
            {
                yield return Assembly.Load(assemblyName);
            }
        }

        private static bool IsMediaPlayerAssembly(AssemblyName assemblyName)
        {
            return assemblyName.Name.StartsWith("MediaPlayer");
        }
    }
}

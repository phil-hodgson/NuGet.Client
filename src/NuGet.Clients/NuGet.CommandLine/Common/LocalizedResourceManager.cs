using System.Globalization;
using System.Resources;
using System.Threading;

namespace NuGet.CommandLine
{
    /// <summary>
    /// A wrapper for string resources located at NuGetResources.resx
    /// </summary>
    internal static class LocalizedResourceManager
    {
        private static readonly ResourceManager _resourceManager = new ResourceManager("NuGet.CommandLine.NuGetResources", typeof(LocalizedResourceManager).Assembly);

        public static string GetString(string resourceName)
        {
            string localizedString = _resourceManager.GetString(resourceName, Thread.CurrentThread.CurrentCulture);

            if (string.IsNullOrEmpty(localizedString))
            {
                // Fallback on existing method
                var culture = GetLanguageName();
                return _resourceManager.GetString(resourceName + '_' + culture, CultureInfo.InvariantCulture) ??
                       _resourceManager.GetString(resourceName, CultureInfo.InvariantCulture);
            }

            return localizedString;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase", Justification = "the convention is to used lower case letter for language name.")]
        /// <summary>
        /// Returns the 3 letter language name used to locate localized resources.
        /// </summary>
        /// <returns>the 3 letter language name used to locate localized resources.</returns>
        public static string GetLanguageName()
        {
            var culture = Thread.CurrentThread.CurrentUICulture;
            while (!culture.IsNeutralCulture)
            {
                if (culture.Parent == culture)
                {
                    break;
                }

                culture = culture.Parent;
            }

            return culture.ThreeLetterWindowsLanguageName.ToLowerInvariant();
        }
    }
}

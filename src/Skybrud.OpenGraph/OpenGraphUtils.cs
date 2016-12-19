using System;
using System.Diagnostics;
using System.Reflection;

namespace Skybrud.OpenGraph {
    
    /// <summary>
    /// Various utility methods used throughout the package.
    /// </summary>
    public static class OpenGraphUtils {

        /// <summary>
        /// Gets the assembly version as a string.
        /// </summary>
        public static string GetVersion() {
            return typeof (OpenGraphUtils).Assembly.GetName().Version.ToString();
        }

        /// <summary>
        /// Gets the file version as a string.
        /// </summary>
        /// <returns></returns>
        public static string GetFileVersion() {
            Assembly assembly = typeof(OpenGraphUtils).Assembly;
            return assembly.Location == null ? null : FileVersionInfo.GetVersionInfo(assembly.Location).FileVersion;
        }

        /// <summary>
        /// Gets the amount of days between the date of this build and the date the project was started - that is the 30th of July, 2012.
        /// </summary>
        public static int GetDaysSinceStart() {

            // Get the third bit as a string
            string str = GetFileVersion().Split('.')[2];

            // Parse the string into an integer
            return Int32.Parse(str);

        }

        /// <summary>
        /// Gets the date of this build of Skybrud.Social.
        /// </summary>
        public static DateTime GetBuildDate() {
            return new DateTime(2014, 11, 30).AddDays(GetDaysSinceStart());
        }

        /// <summary>
        /// Gets the build number of the day. This is mostly used for internal
        /// purposes to distinguish builds with the same assembly version.
        /// </summary>
        public static int GetBuildNumber() {

            // Get the fourth bit as a string
            string str = GetFileVersion().Split('.')[3];

            // Parse the string into an integer
            return Int32.Parse(str);

        }

    }

}

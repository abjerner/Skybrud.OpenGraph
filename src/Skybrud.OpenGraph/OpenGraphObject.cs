using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Web;
using Skybrud.OpenGraph.Attributes;

namespace Skybrud.OpenGraph {

    /// <summary>
    /// Class representing a basic Open Graph object.
    /// </summary>
    public class OpenGraphObject : IHtmlString {

        /// <summary>
        /// Returns a string representation of the object.
        /// </summary>
        /// <returns>A string that represents the object.</returns>
        public override string ToString() {

            // Get an array of all public member properties
            PropertyInfo[] properties = GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);

            StringBuilder sb = new StringBuilder();

            foreach (PropertyInfo propertyInfo in properties) {

                OpenGraphPropertyAttribute customAttribute1 = propertyInfo.GetCustomAttribute<OpenGraphPropertyAttribute>();
                OpenGraphCollectionAttribute customAttribute2 = propertyInfo.GetCustomAttribute<OpenGraphCollectionAttribute>();

                if (customAttribute1 != null) {
                    object obj = propertyInfo.GetValue(this, null);
                    if (obj != null && (!(obj is int) || (int)obj != 0)) {
                        sb.AppendLine(string.Format("<meta property=\"{0}\" content=\"{1}\" />", customAttribute1.Name, HttpUtility.HtmlAttributeEncode(string.Concat(obj))));
                    }
                } else if (customAttribute2 != null) {
                    IEnumerable<OpenGraphObject> enumerable = propertyInfo.GetValue(this, null) as IEnumerable<OpenGraphObject>;
                    if (enumerable != null) {
                        foreach (OpenGraphObject openGraphObject in enumerable) {
                            sb.Append(openGraphObject);
                        }
                    }
                }

            }

            return sb.ToString();

        }

        /// <summary>
        /// Returns a HTML representation of the object.
        /// </summary>
        /// <returns>A string with a HTML value that represents the object.</returns>
        public virtual string ToHtmlString() {
            return ToString();
        }

    }

}
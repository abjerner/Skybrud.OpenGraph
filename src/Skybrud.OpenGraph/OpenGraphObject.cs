using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Web;
using Skybrud.OpenGraph.Attributes;

namespace Skybrud.OpenGraph {

    public class OpenGraphObject : IHtmlString {

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

        public virtual string ToHtmlString() {
            return ToString();
        }

    }

}
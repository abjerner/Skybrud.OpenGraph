using System;

namespace Skybrud.OpenGraph.Attributes {

    /// <summary>
    /// Attribute used for identifying Open Graph properties
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class OpenGraphPropertyAttribute : Attribute {

        /// <summary>
        /// Gets the name of the property.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the property.</param>
        public OpenGraphPropertyAttribute(string name) {
            Name = name;
        }

    }

}
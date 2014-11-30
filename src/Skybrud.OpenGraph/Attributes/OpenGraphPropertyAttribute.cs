using System;

namespace Skybrud.OpenGraph.Attributes {

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class OpenGraphPropertyAttribute : Attribute {

        public string Name { get; private set; }

        public OpenGraphPropertyAttribute(string name) {
            Name = name;
        }

    }

}
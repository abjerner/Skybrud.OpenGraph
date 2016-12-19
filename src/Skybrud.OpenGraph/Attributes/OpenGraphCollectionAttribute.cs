using System;

namespace Skybrud.OpenGraph.Attributes {

    /// <summary>
    /// Attribute used for identifying an Open Graph collection.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class OpenGraphCollectionAttribute : Attribute { }

}
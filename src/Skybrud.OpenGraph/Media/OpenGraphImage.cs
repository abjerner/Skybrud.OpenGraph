using Skybrud.OpenGraph.Attributes;

namespace Skybrud.OpenGraph.Media {

    /// <summary>
    /// Class representing an Open Graph image.
    /// </summary>
    public class OpenGraphImage : OpenGraphMedia {

        #region Properties

        /// <summary>
        /// Gets or sets the HTTP URL of the image.
        /// </summary>
        [OpenGraphProperty("og:image")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the HTTPS URL of the image.
        /// </summary>
        [OpenGraphProperty("og:image:secure_url")]
        public string SecureUrl { get; set; }

        /// <summary>
        /// Gets or sets the type of the image.
        /// </summary>
        [OpenGraphProperty("og:image:type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the width of the image.
        /// </summary>
        [OpenGraphProperty("og:image:width")]
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the height of the image.
        /// </summary>
        [OpenGraphProperty("og:image:height")]
        public int Height { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new image with default values.
        /// </summary>
        public OpenGraphImage() { }

        /// <summary>
        /// Initializes a new image based on the specified <paramref name="url"/>.
        /// </summary>
        /// <param name="url">The URL of the image.</param>
        public OpenGraphImage(string url) {
            Url = url;
        }

        /// <summary>
        /// Initializes a new image based on the specified <paramref name="url"/>, <paramref name="width"/> and <paramref name="height"/>.
        /// </summary>
        /// <param name="url">The URL of the image.</param>
        /// <param name="width">The width of the image.</param>
        /// <param name="height">The height of the image.</param>
        public OpenGraphImage(string url, int width, int height) {
            Url = url;
            Width = width;
            Height = height;
        }

        #endregion

    }

}
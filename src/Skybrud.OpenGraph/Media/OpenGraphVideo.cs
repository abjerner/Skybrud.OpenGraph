using Skybrud.OpenGraph.Attributes;

namespace Skybrud.OpenGraph.Media {

    /// <summary>
    /// Class representing an Open Graph video.
    /// </summary>
    public class OpenGraphVideo : OpenGraphMedia {

        #region Properties

        /// <summary>
        /// Gets or sets the HTTP URL of the video.
        /// </summary>
        [OpenGraphProperty("og:video")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the HTTPS URL of the video.
        /// </summary>
        [OpenGraphProperty("og:video:secure_url")]
        public string SecureUrl { get; set; }

        /// <summary>
        /// Gets or sets the type of the video.
        /// </summary>
        [OpenGraphProperty("og:video:type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the width of the video.
        /// </summary>
        [OpenGraphProperty("og:video:width")]
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the height of the video.
        /// </summary>
        [OpenGraphProperty("og:video:height")]
        public int Height { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance with default values.
        /// </summary>
        public OpenGraphVideo() { }

        /// <summary>
        /// Initializes a new video based on the specified <paramref name="url"/>.
        /// </summary>
        /// <param name="url">The URL of the video.</param>
        public OpenGraphVideo(string url) {
            Url = url;
        }

        /// <summary>
        /// Initializes a new video based on the specified <paramref name="url"/>, <paramref name="width"/> and <paramref name="height"/>.
        /// </summary>
        /// <param name="url">The URL of the video.</param>
        /// <param name="width">The width of the video.</param>
        /// <param name="height">The height of the video.</param>
        public OpenGraphVideo(string url, int width, int height) {
            Url = url;
            Width = width;
            Height = height;
        }

        #endregion

    }

}
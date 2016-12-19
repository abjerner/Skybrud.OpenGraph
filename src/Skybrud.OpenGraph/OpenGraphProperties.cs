using Skybrud.OpenGraph.Attributes;
using Skybrud.OpenGraph.Media;

namespace Skybrud.OpenGraph {

    /// <summary>
    /// Class representing the basic Open Graph properties.
    /// </summary>
    public class OpenGraphProperties : OpenGraphObject {

        /// <summary>
        /// Gets a reference to the <see cref="OpenGraphMediaCollection"/> used for keeping track of the added media.
        /// </summary>
        protected readonly OpenGraphMediaCollection MediaCollection = new OpenGraphMediaCollection();

        #region Properties

        /// <summary>
        /// Gets or sets the title of the current page.
        /// </summary>
        [OpenGraphProperty("og:title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the name of the site.
        /// </summary>
        [OpenGraphProperty("og:site_name")]
        public string SiteName { get; set; }

        /// <summary>
        /// Gets or sets the URL of the page.
        /// </summary>
        [OpenGraphProperty("og:url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the type of the page.
        /// </summary>
        [OpenGraphProperty("og:type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the description of the page.
        /// </summary>
        [OpenGraphProperty("og:description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets a reference to an instanceo of <see cref="OpenGraphMediaCollection"/> representing the Open Graph
        /// media of the page.
        /// </summary>
        [OpenGraphCollection]
        public OpenGraphMediaCollection Media {
            get { return MediaCollection; }
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Adds an image with the specified <code>url</code>.
        /// </summary>
        /// <param name="url">The URL of the image.</param>
        public virtual OpenGraphProperties AddImage(string url) {
            return AddImage(url, 0, 0);
        }

        /// <summary>
        /// Adds an image with the specified <code>url</code>, <code>width</code> and <code>height</code>.
        /// </summary>
        /// <param name="url">The URL of the image.</param>
        /// <param name="width">The width of the image.</param>
        /// <param name="height">The height of the image.</param>
        public virtual OpenGraphProperties AddImage(string url, int width, int height) {
            return AddImage(new OpenGraphImage {
                Url = url,
                Width = width,
                Height = height
            });
        }

        /// <summary>
        /// Adds the specified <code>image</code>.
        /// </summary>
        /// <param name="image">The image to be added.</param>
        public virtual OpenGraphProperties AddImage(OpenGraphImage image) {
            Media.Add(image);
            return this;
        }

        /// <summary>
        /// Adds a video with the specified <code>url</code>.
        /// </summary>
        /// <param name="url">The URL of the video.</param>
        public virtual OpenGraphProperties AddVideo(string url) {
            return AddVideo(url, 0, 0);
        }

        /// <summary>
        /// Adds a video with the specified <code>url</code>, <code>width</code> and <code>height</code>.
        /// </summary>
        /// <param name="url">The URL of the video.</param>
        /// <param name="width">The width of the video.</param>
        /// <param name="height">The height of the video.</param>
        public virtual OpenGraphProperties AddVideo(string url, int width, int height) {
            return AddVideo(new OpenGraphVideo {
                Url = url,
                Width = width,
                Height = height
            });
        }

        /// <summary>
        /// Adds the specified <code>video</code>.
        /// </summary>
        /// <param name="video">The video to be added.</param>
        public virtual OpenGraphProperties AddVideo(OpenGraphVideo video) {
            Media.Add(video);
            return this;
        }

        #endregion

    }

}
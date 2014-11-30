using Skybrud.OpenGraph.Attributes;
using Skybrud.OpenGraph.Media;

namespace Skybrud.OpenGraph {

    public class OpenGraphProperties : OpenGraphObject {

        private readonly OpenGraphMediaCollection _media = new OpenGraphMediaCollection();

        [OpenGraphProperty("og:title")]
        public string Title { get; set; }

        [OpenGraphProperty("og:site_name")]
        public string SiteName { get; set; }

        [OpenGraphProperty("og:url")]
        public string Url { get; set; }

        [OpenGraphProperty("og:type")]
        public string Type { get; set; }

        [OpenGraphProperty("og:description")]
        public string Description { get; set; }

        [OpenGraphCollection]
        public OpenGraphMediaCollection Media {
            get { return _media; }
        }

        /// <summary>
        /// Adds an image with the specified <code>url</code>.
        /// </summary>
        /// <param name="url">The URL of the image.</param>
        public OpenGraphProperties AddImage(string url) {
            return AddImage(url, 0, 0);
        }

        /// <summary>
        /// Adds an image with the specified <code>url</code>, <code>width</code> and <code>height</code>.
        /// </summary>
        /// <param name="url">The URL of the image.</param>
        /// <param name="width">The width of the image.</param>
        /// <param name="height">The height of the image.</param>
        public OpenGraphProperties AddImage(string url, int width, int height) {
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
        public OpenGraphProperties AddImage(OpenGraphImage image) {
            Media.Add(image);
            return this;
        }

        /// <summary>
        /// Adds a video with the specified <code>url</code>.
        /// </summary>
        /// <param name="url">The URL of the video.</param>
        public OpenGraphProperties AddVideo(string url) {
            return AddVideo(url, 0, 0);
        }

        /// <summary>
        /// Adds a video with the specified <code>url</code>, <code>width</code> and <code>height</code>.
        /// </summary>
        /// <param name="url">The URL of the video.</param>
        /// <param name="width">The width of the video.</param>
        /// <param name="height">The height of the video.</param>
        public OpenGraphProperties AddVideo(string url, int width, int height) {
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
        public OpenGraphProperties AddVideo(OpenGraphVideo video) {
            Media.Add(video);
            return this;
        }

    }

}
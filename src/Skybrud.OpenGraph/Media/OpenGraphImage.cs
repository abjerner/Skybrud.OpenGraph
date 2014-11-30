using Skybrud.OpenGraph.Attributes;

namespace Skybrud.OpenGraph.Media {

    public class OpenGraphImage : OpenGraphMedia {

        [OpenGraphProperty("og:image")]
        public string Url { get; set; }

        [OpenGraphProperty("og:image:secure_url")]
        public string SecureUrl { get; set; }

        [OpenGraphProperty("og:image:type")]
        public string Type { get; set; }

        [OpenGraphProperty("og:image:width")]
        public int Width { get; set; }

        [OpenGraphProperty("og:image:height")]
        public int Height { get; set; }

        public OpenGraphImage() { }

        public OpenGraphImage(string url) {
            Url = url;
        }

        public OpenGraphImage(string url, int width, int height) {
            Url = url;
            Width = width;
            Height = height;
        }

    }

}
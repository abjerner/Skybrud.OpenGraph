using Skybrud.OpenGraph.Attributes;

namespace Skybrud.OpenGraph.Media {

    public class OpenGraphVideo : OpenGraphMedia {
        [OpenGraphProperty("og:video")]
        public string Url { get; set; }

        [OpenGraphProperty("og:video:secure_url")]
        public string SecureUrl { get; set; }

        [OpenGraphProperty("og:video:type")]
        public string Type { get; set; }

        [OpenGraphProperty("og:video:width")]
        public int Width { get; set; }

        [OpenGraphProperty("og:video:height")]
        public int Height { get; set; }

        public OpenGraphVideo() {
        }

        public OpenGraphVideo(string url) {
            Url = url;
        }

        public OpenGraphVideo(string url, int width, int height) {
            Url = url;
            Width = width;
            Height = height;
        }

    }

}
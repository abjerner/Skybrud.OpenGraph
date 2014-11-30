using System.Collections;
using System.Collections.Generic;

namespace Skybrud.OpenGraph.Media {

    public class OpenGraphMediaCollection : IEnumerable<OpenGraphMedia> {

        private readonly List<OpenGraphMedia> _media = new List<OpenGraphMedia>();

        public void Add(OpenGraphMedia media) {
            if (media == null) return;
            _media.Add(media);
        }

        public void Clear() {
            _media.Clear();
        }

        public IEnumerator<OpenGraphMedia> GetEnumerator() {
            return _media.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

    }

}
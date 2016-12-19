using System.Collections;
using System.Collections.Generic;

namespace Skybrud.OpenGraph.Media {

    /// <summary>
    /// Class representing a collection of <see cref="OpenGraphMedia"/>.
    /// </summary>
    public class OpenGraphMediaCollection : IEnumerable<OpenGraphMedia> {

        private readonly List<OpenGraphMedia> _media = new List<OpenGraphMedia>();

        /// <summary>
        /// Appends the specified <paramref name="media"/>.
        /// </summary>
        /// <param name="media">The instance of <see cref="OpenGraphMedia"/> to be added.</param>
        public virtual void Add(OpenGraphMedia media) {
            if (media == null) return;
            _media.Add(media);
        }

        /// <summary>
        /// Appends the specified collection of <paramref name="media"/>.
        /// </summary>
        /// <param name="media">The collection of <see cref="OpenGraphMedia"/> to be added.</param>
        public virtual void AddRange(IEnumerable<OpenGraphMedia> media) {
            if (media == null) return;
            _media.AddRange(media);
        }

        /// <summary>
        /// Inserts the specified <paramref name="media"/> at <paramref name="index"/>.
        /// </summary>
        /// <param name="index">The index where <paramref name="media"/> should be added.</param>
        /// <param name="media">The instance of <see cref="OpenGraphMedia"/> to be added.</param>
        public virtual void AddAt(int index, OpenGraphMedia media) {
            if (media == null) return;
            _media.Insert(index, media);
        }

        /// <summary>
        /// Inserts the specified <paramref name="media"/> at <paramref name="index"/>.
        /// </summary>
        /// <param name="index">The index where <paramref name="media"/> should be added.</param>
        /// <param name="media">The collection of <see cref="OpenGraphMedia"/> to be added.</param>
        public virtual void AddRangeAt(int index, IEnumerable<OpenGraphMedia> media) {
            if (media == null) return;
            _media.InsertRange(index, media);
        }

        /// <summary>
        /// Removes all elements from the collection.
        /// </summary>
        public virtual void Clear() {
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
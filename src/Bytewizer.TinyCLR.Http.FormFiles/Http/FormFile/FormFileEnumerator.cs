﻿using System.Collections;

namespace Bytewizer.TinyCLR.Http.FormFiles
{
    /// <summary>
    /// Provides a class for enumerating over key/value pairs.
    /// </summary>
    public class FormFileEnumerator : IEnumerator
    {
        private readonly FormFileCollection _collection;
        private int _index = -1;

        /// <summary>
        /// Creates a new instance of type <see cref="FormFileEnumerator"/>.
        /// </summary>
        public FormFileEnumerator(FormFileCollection collection)
        {
            _collection = collection;
        }

        #region IEnumerator Members

        /// <summary>
        /// Gets the current key/value pair.
        /// </summary>
        object IEnumerator.Current
        {
            get { return Current; }
        }

        /// <summary>
        /// Gets the current key/value pair.
        /// </summary>
        public FormFileValue Current
        {
            get
            {
                if (_collection == null)
                {
                    return new FormFileValue();
                }

                return _collection[_index];
            }
        }

        /// <summary>
        /// Moves top the next item in the enumerator.
        /// </summary>
        public bool MoveNext()
        {
            _index++;
            if (_index < _collection.Count)
            {
                return true;
            }
            else
            {
                _index = -1;
                return false;
            }
        }

        /// <summary>
        /// Resets the enumerator to it's initial state.
        /// </summary>
        public void Reset()
        {
            _index = -1;
        }

        #endregion
    }
}

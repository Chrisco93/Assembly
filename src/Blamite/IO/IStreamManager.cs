﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Blamite.IO
{
    /// <summary>
    /// Interface for a class that manages an object which streams can be opened on.
    /// </summary>
    public interface IStreamManager
    {
        /// <summary>
        /// The suggested endianness to read/write the stream with.
        /// </summary>
        Endian SuggestedEndian { get; }

        /// <summary>
        /// Opens the backed object for reading.
        /// </summary>
        /// <returns>The stream that was opened on the object.</returns>
        Stream OpenRead();

        /// <summary>
        /// Opens the backed object for writing.
        /// </summary>
        /// <returns>The stream that was opened on the object.</returns>
        Stream OpenWrite();

        /// <summary>
        /// Opens the backed object for reading and writing.
        /// </summary>
        /// <returns>The stream that was opened on the object.</returns>
        Stream OpenReadWrite();
    }
}

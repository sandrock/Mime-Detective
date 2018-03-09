﻿using System;
using static MimeDetective.InputHelpers;

namespace MimeDetective
{
	public static class ByteArrayExtensions
	{
		/// <summary>
		/// Read header of bytes and depending on the information in the header
		/// return object FileType.
		/// Return null in case when the file type is not identified.
		/// Throws Application exception if the file can not be read or does not exist
		/// </summary>
		/// <param name="file">The FileInfo object.</param>
		/// <returns>FileType or null not identified</returns>
		public static FileType GetFileType(this byte[] bytes)
		{
			if (bytes is null)
				throw new ArgumentNullException(nameof(bytes));

			ReadResult readResult = new ReadResult(bytes, bytes.Length);

			return MimeTypes.GetFileType(in readResult);
		}
	}
}
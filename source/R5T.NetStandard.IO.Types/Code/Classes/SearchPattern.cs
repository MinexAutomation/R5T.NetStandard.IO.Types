﻿using System;

using R5T.NetStandard.IO.Extensions;
using R5T.NetStandard.IO.Paths;


namespace R5T.NetStandard.IO
{
    /// <summary>
    /// Strongly-typed string search-pattern for use with <see cref="System.IO"/> types.
    /// </summary>
    public class SearchPattern : TypedString
    {
        public const char WildCardChar = '*';
        public static readonly string WildCard = SearchPattern.WildCardChar.ToString();


        #region Static

        /// <summary>
        /// Gets a search pattern that will find all with a specific file extension.
        /// Note the file extension can include the file extension separator token ('.') or not; the function will work either way.
        /// </summary>
        public static SearchPattern AllFilesWithFileExtension(FileExtension fileExtension)
        {
            var searchPattern = $"{SearchPattern.WildCard}{FileExtensionSeparator.Default}{fileExtension}".AsSearchPattern();
            return searchPattern;
        }

        #endregion


        public SearchPattern(string value)
            : base(value)
        {
        }
    }
}

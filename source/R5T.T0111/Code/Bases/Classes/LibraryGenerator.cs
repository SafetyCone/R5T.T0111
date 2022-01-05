using System;


namespace R5T.T0111
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class LibraryGenerator : ILibraryGenerator
    {
        #region Static
        
        public static LibraryGenerator Instance { get; } = new();

        #endregion
    }
}
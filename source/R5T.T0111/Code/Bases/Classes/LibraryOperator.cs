using System;


namespace R5T.T0111
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class LibraryOperator : ILibraryOperator
    {
        #region Static
        
        public static LibraryOperator Instance { get; } = new();

        #endregion
    }
}
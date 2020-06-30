using System.Runtime.CompilerServices;

namespace MoonPdfLib.Helper
{
    internal  class ContentStateManager
    {
        /// <summary>Initializes a new instance of the <see cref="T:System.Object" /> class.</summary>
        public ContentStateManager()
        {
            State = ContentState.UnLoaded;
        }

        public  ContentState State
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set;
        }
    }
}
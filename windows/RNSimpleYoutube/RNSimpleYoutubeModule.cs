using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Simple.Youtube.RNSimpleYoutube
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNSimpleYoutubeModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNSimpleYoutubeModule"/>.
        /// </summary>
        internal RNSimpleYoutubeModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNSimpleYoutube";
            }
        }
    }
}

using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Com.Reactlibrary.RNCachedVideo
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNCachedVideoModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNCachedVideoModule"/>.
        /// </summary>
        internal RNCachedVideoModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNCachedVideo";
            }
        }
    }
}

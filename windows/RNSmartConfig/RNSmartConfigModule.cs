using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Smart.Config.RNSmartConfig
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNSmartConfigModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNSmartConfigModule"/>.
        /// </summary>
        internal RNSmartConfigModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNSmartConfig";
            }
        }
    }
}

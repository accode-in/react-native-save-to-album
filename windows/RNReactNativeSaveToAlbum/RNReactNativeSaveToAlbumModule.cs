using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace React.Native.Save.To.Album.RNReactNativeSaveToAlbum
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNReactNativeSaveToAlbumModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNReactNativeSaveToAlbumModule"/>.
        /// </summary>
        internal RNReactNativeSaveToAlbumModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNReactNativeSaveToAlbum";
            }
        }
    }
}

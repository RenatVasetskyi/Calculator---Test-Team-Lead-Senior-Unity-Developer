using Architecture.Services.Interfaces;
using UnityEngine;

namespace Architecture.Services
{
    public class AssetProvider : IAssetProvider
    {
        //I didn't add addressables and asynchronous loading from resources
        //and their caching to complicate the system at the very beginning.
        public T Load<T>(string path) where T : Object
        {
            return Resources.Load<T>(path);
        }
    }
}
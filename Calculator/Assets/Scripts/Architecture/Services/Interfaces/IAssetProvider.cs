using UnityEngine;

namespace Architecture.Services.Interfaces
{
    public interface IAssetProvider
    {
        T Load<T>(string path) where T : Object;
    }
}
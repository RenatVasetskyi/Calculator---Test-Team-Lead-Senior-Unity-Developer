using UnityEngine;

namespace Business.Architecture.Services.Interfaces
{
    public interface IAssetProvider
    {
        T Load<T>(string path) where T : Object;
    }
}
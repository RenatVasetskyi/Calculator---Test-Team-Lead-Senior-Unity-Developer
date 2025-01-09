using UnityEngine;

namespace Architecture.Services.Interfaces
{
    public interface IFactory
    {
        T CreateBaseWithContainer<T>(string path, Transform parent) where T : Component;
        GameObject CreateBaseWithContainer(GameObject prefab, Transform parent);
        T CreateBaseWithObject<T>(string path) where T : Component;
    }
}
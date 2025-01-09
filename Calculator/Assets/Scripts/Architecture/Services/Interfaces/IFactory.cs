using UnityEngine;

namespace Architecture.Services.Interfaces
{
    public interface IFactory
    {
        T CreateBaseWithContainer<T>(string path, Transform parent) where T : Component;
        T CreateBaseWithObject<T>(string path) where T : Component;
    }
}
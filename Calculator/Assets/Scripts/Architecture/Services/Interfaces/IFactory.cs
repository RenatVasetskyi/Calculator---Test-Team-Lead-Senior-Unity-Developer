using UnityEngine;

namespace Architecture.Services.Interfaces
{
    public interface IFactory
    {
        T CreateBaseWithContainer<T>(string path) where T : Component;
    }
}
using Architecture.Services.Interfaces;
using Data;
using UnityEngine;
using Zenject;
using Component = UnityEngine.Component;
using IFactory = Architecture.Services.Interfaces.IFactory;

namespace Architecture.Services
{
    public class BaseFactory : IFactory
    {
        private readonly DiContainer _container;
        private readonly IAssetProvider _assetProvider;
        
        protected BaseFactory(DiContainer container, IAssetProvider assetProvider)
        {
            _container = container;
            _assetProvider = assetProvider;
        }

        public T CreateBaseWithContainer<T>(string path, Transform parent) where T : Component
        {
            return _container.InstantiatePrefabForComponent<T>(_assetProvider.Load<T>(path), parent);
        }

        public T CreateBaseWithObject<T>(string path) where T : Component
        {
            return Object.Instantiate<T>(_assetProvider.Load<T>(path));
        }
    }
}
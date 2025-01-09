using Architecture.Services;
using Architecture.Services.Interfaces;
using Zenject;
using IFactory = Architecture.Services.Interfaces.IFactory;

namespace Architecture.Installers
{
    public class ServiceInstaller : MonoInstaller, ICoroutineRunner
    {
        public override void InstallBindings()
        {
            BindCoroutineRunner();
            BindSceneLoader();
            BindAssetProvider();
            BindBaseFactory();
            BindCalculatorFactory();
            BindCalculatorCashService();
        }
        
        private void BindCoroutineRunner()
        {
            Container
                .BindInterfacesTo<ServiceInstaller>()
                .FromInstance(this)
                .AsSingle()
                .NonLazy();
        }

        private void BindSceneLoader()
        {
            Container
                .Bind<ISceneLoader>()
                .To<SceneLoader>()
                .AsSingle()
                .NonLazy();
        }
        
        private void BindAssetProvider()
        {
            Container
                .Bind<IAssetProvider>()
                .To<AssetProvider>()
                .AsSingle();
        }

        private void BindBaseFactory()
        {
            Container
                .Bind<IFactory>()
                .To<BaseFactory>()
                .AsSingle();
        }
        
        private void BindCalculatorFactory()
        {
            Container
                .Bind<ICalculatorFactory>()
                .To<CalculatorFactory>()
                .AsSingle();
        }
        
        private void BindCalculatorCashService()
        {
            Container
                .Bind<ICalculatorCashService>()
                .To<CalculatorCashService>()
                .AsSingle();
        }
    }
}
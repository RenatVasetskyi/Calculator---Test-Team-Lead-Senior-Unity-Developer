using Architecture.States;
using Architecture.States.Interfaces;
using StateMachine = Architecture.States.StateMachine;
using Zenject;

namespace Architecture.Installers
{
    public class BootstrapInstaller : MonoInstaller, IInitializable
    {
        public override void InstallBindings()
        {
            BindInterfaces();
            BindStateMachine();
            BindStates();
            AddStatesToStateMachine();
        }

        public void Initialize()
        {
            Container
                .Resolve<IStateMachine>()
                .Enter<BootstrapState>();
        }

        private void BindStates()
        {
            Container.Bind<BootstrapState>().AsSingle();
            Container.Bind<MainMenuState>().AsSingle();
            Container.Bind<ProgramState>().AsSingle();
        }

        private void AddStatesToStateMachine()
        {
            IStateMachine stateMachine = Container.Resolve<IStateMachine>();

            stateMachine.States.Add(typeof(BootstrapState), Container.Resolve<BootstrapState>());
            stateMachine.States.Add(typeof(MainMenuState), Container.Resolve<MainMenuState>());
            stateMachine.States.Add(typeof(ProgramState), Container.Resolve<ProgramState>());
        }

        private void BindStateMachine()
        {
            Container
                .Bind<IStateMachine>()
                .To<StateMachine>()
                .AsSingle();
        }

        private void BindInterfaces()
        {
            Container
                .BindInterfacesTo<BootstrapInstaller>()
                .FromInstance(this)
                .AsSingle()
                .NonLazy();
        }
    }
}
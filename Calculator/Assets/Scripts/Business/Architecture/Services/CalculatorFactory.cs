using Business.Architecture.Services.Interfaces;
using Business.CalculatorProgram.Error.Interfaces;
using Business.CalculatorProgram.Mediator.Interfaces;
using Business.Data;
using UnityEngine;
using Zenject;

namespace Business.Architecture.Services
{
    public class CalculatorFactory : BaseFactory, ICalculatorFactory
    {
        private readonly IAssetProvider _assetProvider;
        public ICalculatorWindow Calculator { get; private set; }
        public ICalculatorErrorWindow CalculatorErrorWindow { get; private set; }
        public Transform Container { get; private set; }

        protected CalculatorFactory(DiContainer container,
            IAssetProvider assetProvider) : base(container, assetProvider)
        {
            _assetProvider = assetProvider;
        }

        public Transform CreateContainer()
        {
            Container = CreateBaseWithObject<Transform>(ResourcesLoadingPaths.Container);
            return Container;
        }
        
        public ICalculatorWindow CreateCalculator()
        {
            GameObject calculator = CreateBaseWithContainer(_assetProvider
                .Load<GameObject>(ResourcesLoadingPaths.CalculatorUI), Container);
            return calculator.GetComponent<ICalculatorWindow>();
        }

        public ICalculatorErrorWindow CreateErrorPopup()
        {
            GameObject calculator = CreateBaseWithContainer(_assetProvider
                .Load<GameObject>(ResourcesLoadingPaths.InputErrorPopup), Container);
            return calculator.GetComponent<ICalculatorErrorWindow>();
        }
    }
}
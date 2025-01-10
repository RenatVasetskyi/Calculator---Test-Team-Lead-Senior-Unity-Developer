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
        
        private Transform _container;

        protected CalculatorFactory(DiContainer container,
            IAssetProvider assetProvider) : base(container, assetProvider)
        {
            _assetProvider = assetProvider;
        }

        public Transform CreateContainer()
        {
            _container = CreateBaseWithObject<Transform>(ResourcesLoadingPaths.Container);
            return _container;
        }
        
        public ICalculatorWindow CreateCalculator()
        {
            GameObject calculator = CreateBaseWithContainer(_assetProvider
                .Load<GameObject>(ResourcesLoadingPaths.CalculatorUI), _container);
            
            Calculator = calculator.GetComponent<ICalculatorWindow>();
            
            return Calculator;
        }

        public ICalculatorErrorWindow CreateErrorPopup()
        {
            GameObject calculator = CreateBaseWithContainer(_assetProvider
                .Load<GameObject>(ResourcesLoadingPaths.InputErrorPopup), _container);
            
            CalculatorErrorWindow = calculator.GetComponent<ICalculatorErrorWindow>();
            
            return CalculatorErrorWindow;
        }
    }
}
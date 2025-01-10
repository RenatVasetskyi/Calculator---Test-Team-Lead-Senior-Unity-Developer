using Business.Architecture.Services.Interfaces;
using Business.Data;
using Mono;
using UnityEngine;
using Zenject;

namespace Business.Architecture.Services
{
    public class CalculatorFactory : BaseFactory, ICalculatorFactory
    {
        public Calculator Calculator { get; private set; }
        public CalculatorErrorWindow CalculatorErrorWindow { get; private set; }
        public Transform Container { get; private set; }
        
        protected CalculatorFactory(DiContainer container, 
            IAssetProvider assetProvider) : base(container, assetProvider) { }

        public Transform CreateContainer()
        {
            Container = CreateBaseWithObject<Transform>(ResourcesLoadingPaths.Container);
            return Container;
        }
        
        public Calculator CreateCalculator()
        {
            Calculator = CreateBaseWithContainer<Calculator>(ResourcesLoadingPaths.CalculatorUI, Container);
            return Calculator;
        }

        public CalculatorErrorWindow CreateErrorPopup()
        {
            CalculatorErrorWindow = CreateBaseWithContainer<CalculatorErrorWindow>(ResourcesLoadingPaths
                .InputErrorPopup, Container);
            return CalculatorErrorWindow;
        }
    }
}
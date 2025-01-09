using Architecture.Services.Interfaces;
using Data;
using UnityEngine;
using Zenject;

namespace Architecture.Services
{
    public class CalculatorFactory : BaseFactory, ICalculatorFactory
    {
        public Canvas CalculatorCanvas { get; private set; }
        
        protected CalculatorFactory(DiContainer container, 
            IAssetProvider assetProvider) : base(container, assetProvider)
        {
        }
        
        public Canvas CreateCalculatorCanvas()
        {
            CalculatorCanvas = CreateBaseWithContainer<Canvas>(ResourcesLoadingPaths.CalculatorUI, null);
            return CalculatorCanvas;
        }
    }
}
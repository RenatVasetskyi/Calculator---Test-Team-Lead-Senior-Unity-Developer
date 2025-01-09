using Architecture.Services.Interfaces;
using CalculatorProgram.Interfaces;
using Data;
using UnityEngine;

namespace CalculatorProgram.Business
{
    public class CalculatorErrorHandler : ICalculatorObserver
    {
        private readonly ICalculatorFactory _factory;

        public CalculatorErrorHandler(ICalculatorFactory factory)
        {
            _factory = factory;
        }
        
        public void GetInfo(string exception)
        {
            Transform inputErrorPopup = _factory.CreateBaseWithContainer<Transform>(ResourcesLoadingPaths
                .InputErrorPopup, _factory.CalculatorCanvas.transform);
        }
    }
}
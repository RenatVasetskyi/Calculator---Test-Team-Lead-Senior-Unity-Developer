using System;
using CalculatorProgram.Error.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace CalculatorProgram.Error.Business
{
    [Serializable]
    public class CalculatorErrorWindowView : ICalculatorErrorView
    { 
        [SerializeField] private Button _closeButton;

        public Button CloseButton => _closeButton;
    }
}
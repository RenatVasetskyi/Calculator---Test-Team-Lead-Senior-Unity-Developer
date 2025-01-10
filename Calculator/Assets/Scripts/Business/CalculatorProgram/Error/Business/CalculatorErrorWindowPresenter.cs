using Business.CalculatorProgram.Error.Interfaces;
using UnityEngine;

namespace Business.CalculatorProgram.Error.Business
{
    public class CalculatorErrorWindowPresenter : ICalculatorErrorWindowPresenter
    {
        private readonly ICalculatorErrorWindowModel _model;

        public CalculatorErrorWindowPresenter(ICalculatorErrorWindowModel model)
        {
            _model = model;
        }
        
        public void DeleteMyself(GameObject gameObject)
        {
            _model.DeleteMyself(gameObject);
        }
    }
}
using CalculatorProgram.Error.Business;
using CalculatorProgram.Error.Interfaces;
using CalculatorProgram.Mediator.Interfaces;
using UnityEngine;

namespace CalculatorProgram.Error
{
    public class CalculatorErrorWindow : MonoBehaviour, ICalculatorErrorWindow
    {
        private readonly ICalculatorErrorWindowPresenter _calculatorErrorWindowPresenter = new 
            CalculatorErrorWindowPresenter(new CalculatorErrorWindowModel());
        
        [SerializeField] private CalculatorErrorWindowView _view;
        
        private ICalculatorWindowMediator _mediator;

        public void Initialize(ICalculatorWindowMediator mediator)
        {
            _mediator = mediator;
        }
        
        public void DeleteMyself()
        {
            if (_mediator != null)
                _mediator.ShowCalculatorWindow();
            else
                _calculatorErrorWindowPresenter.DeleteMyself(gameObject);
        }

        public void Hide()
        {
            _calculatorErrorWindowPresenter.DeleteMyself(gameObject);
        }

        private void OnEnable()
        {
            _view.CloseButton.onClick.AddListener(DeleteMyself);
        }

        private void OnDisable()
        {
            _view.CloseButton.onClick.RemoveListener(DeleteMyself);
        }
    }
}
using Business.CalculatorProgram.Error.Business;
using Business.CalculatorProgram.Error.Interfaces;
using Business.CalculatorProgram.Mediator.Interfaces;
using UnityEngine;

namespace Mono
{
    public class CalculatorErrorWindow : MonoBehaviour, ICalculatorErrorWindow
    {
        private readonly ICalculatorErrorWindowPresenter _calculatorErrorWindowPresenter = new 
            CalculatorErrorWindowPresenter(new CalculatorErrorWindowModel());
        
        [SerializeField] private CalculatorErrorWindowView _view;
        
        private ICalculatorWindowMediator _mediator;
        
        public GameObject GameObject => gameObject;

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
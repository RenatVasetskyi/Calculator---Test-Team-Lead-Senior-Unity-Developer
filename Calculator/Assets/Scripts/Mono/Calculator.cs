using Business.Architecture.Services.Interfaces;
using Business.CalculatorProgram.Business;
using Business.CalculatorProgram.Interfaces;
using Business.CalculatorProgram.Mediator;
using Business.CalculatorProgram.Mediator.Interfaces;
using Business.CalculatorProgram.Text;
using Business.CalculatorProgram.Window;
using UnityEngine;
using Zenject;

namespace Mono
{
    public class Calculator : MonoBehaviour, ICalculatorWindow
    {
        [SerializeField] private CalculatorView _view;

        private ICalculatorFactory _calculatorFactory;
        private ICalculatorCashService _calculatorCashService;
        private ICalculatorObserver _calculatorMediator;
        
        private ICalculator _model;
        private ICalculatorPresenter _presenter;

        [Inject]
        public void Inject(ICalculatorFactory calculatorFactory, ICalculatorCashService calculatorCashService)
        {
            _calculatorFactory = calculatorFactory;
            _calculatorCashService = calculatorCashService;
        }
        
        public void Hide()
        {
            Destroy(gameObject);
        }

        private void Awake()
        {
            _model = new CalculatorModel(new CalculatorValidator(), new StringSplitter(),
                _calculatorCashService, new WindowResizer(), new TextResizer());
            _presenter = new CalculatorPresenter(_view, _model);
            _calculatorMediator = new CalculatorWindowMediator(_calculatorFactory);
            _model.Subscribe(_calculatorMediator);
            _view.ResultButton.onClick.AddListener(OnResultButtonClicked);
            _presenter.ShowCash();
            _presenter.ShowCurrentInput();
            _presenter.Resize();
        }

        private void OnDestroy()
        {
            _view.ResultButton.onClick.RemoveListener(OnResultButtonClicked);
            _model.UnSubscribe(_calculatorMediator);
            _presenter.SaveCurrentInput();
        }

        private void OnResultButtonClicked()
        {
            _presenter.OnResultButtonClicked();
        }
    }
}
﻿using Architecture.Services.Interfaces;
using CalculatorProgram.Business;
using CalculatorProgram.Interfaces;
using CalculatorProgram.Mediator;
using CalculatorProgram.Mediator.Interfaces;
using UnityEngine;
using Zenject;

namespace CalculatorProgram
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
            _model = new CalculatorModel(new CalculatorValidator(), new StringSplitter(), _calculatorCashService);
            _presenter = new CalculatorPresenter(_view, _model);
            _calculatorMediator = new CalculatorWindowMediator(_calculatorFactory);
            _model.Subscribe(_calculatorMediator);
            _view.ResultButton.onClick.AddListener(OnResultButtonClicked);
            _presenter.ShowCash();
            _presenter.ShowCurrentInput();
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
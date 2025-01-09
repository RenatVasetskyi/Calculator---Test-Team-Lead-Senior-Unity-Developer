using CalculatorProgram.Business;
using CalculatorProgram.Interfaces;
using CalculatorProgram.UI;
using UnityEngine;

namespace CalculatorProgram
{
    public class Calculator : MonoBehaviour
    {
        [SerializeField] private CalculatorView _view;

        private ICalculatorPresenter _presenter;

        private void Awake()
        {
            ICalculator model = new CalculatorModel(new CalculatorValidator(), new StringSplitter());
            _presenter = new CalculatorPresenter(_view, model);
            _view.ResultButton.onClick.AddListener(OnResultButtonClicked);
        }

        private void OnDestroy()
        {
            _view.ResultButton.onClick.RemoveListener(OnResultButtonClicked);
        }

        private void OnResultButtonClicked()
        {
            _presenter.OnResultButtonClicked();
        }
    }
}
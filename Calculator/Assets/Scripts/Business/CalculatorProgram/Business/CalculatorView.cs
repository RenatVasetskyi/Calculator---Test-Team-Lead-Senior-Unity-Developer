using System;
using Business.CalculatorProgram.Interfaces;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Business.CalculatorProgram.Business
{
    [Serializable]
    public class CalculatorView : ICalculatorView
    {
        [SerializeField] private RectTransform _window;
        [SerializeField] private TMP_InputField _inputField;
        [SerializeField] private TextMeshProUGUI _resultText;
        [SerializeField] private Button _resultButton;

        public TextMeshProUGUI ResultText => _resultText;
        public string InputText => _inputField.text;
        public Button ResultButton => _resultButton;
        public RectTransform Window => _window;

        public void ShowResult(string result)
        {
            _resultText.text = result;
            _inputField.text = string.Empty;
        }

        public void ShowCurrentInput(string input)
        {
            _inputField.text = input;
        }
    }
}
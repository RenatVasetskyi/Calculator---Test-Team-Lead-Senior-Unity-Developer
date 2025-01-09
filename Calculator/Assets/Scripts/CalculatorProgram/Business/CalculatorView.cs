using System;
using CalculatorProgram.Interfaces;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CalculatorProgram.Business
{
    [Serializable]
    public class CalculatorView : ICalculatorView
    {
        [SerializeField] private TMP_InputField _inputField;
        [SerializeField] private TextMeshProUGUI _resultText;
        [SerializeField] private Button _resultButton;

        public string InputText => _inputField.text;
        public Button ResultButton => _resultButton;

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
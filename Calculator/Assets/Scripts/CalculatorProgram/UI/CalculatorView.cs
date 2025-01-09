using CalculatorProgram.Interfaces;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace CalculatorProgram.UI
{
    public class CalculatorView : MonoBehaviour, ICalculatorView
    {
        [SerializeField] private TMP_InputField _inputField;
        [SerializeField] private TextMeshProUGUI _resultText;
        [SerializeField] private Button _resultButton;

        public string InputText => _inputField.text;
        public Button ResultButton => _resultButton;

        public void ShowResult(string result)
        {
            _resultText.text = result;
        }

        public void ShowError(string result)
        {
            _resultText.text = $"Error: {result}";
        }
    }
}
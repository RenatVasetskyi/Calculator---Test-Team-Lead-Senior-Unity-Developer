using TMPro;
using UnityEngine;

namespace Business.CalculatorProgram.Interfaces
{
    public interface ICalculator
    {
        string AddNumbers(string input);
        string GetCash();
        void SaveCurrentInput(string input);
        string GetCurrentInput();
        void ChangeTextSize(TextMeshProUGUI textComponent, RectTransform rectTransform);
        void Subscribe(ICalculatorObserver observer);
        void UnSubscribe(ICalculatorObserver observer);
    }
}
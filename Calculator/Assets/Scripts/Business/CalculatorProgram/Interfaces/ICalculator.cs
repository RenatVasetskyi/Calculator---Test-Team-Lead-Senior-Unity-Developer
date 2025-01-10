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
        float ChangeTextSizeY(TextMeshProUGUI textComponent, RectTransform rectTransform);
        float ResizeWindowY(RectTransform window, float addY);
        void Subscribe(ICalculatorObserver observer);
        void UnSubscribe(ICalculatorObserver observer);
    }
}
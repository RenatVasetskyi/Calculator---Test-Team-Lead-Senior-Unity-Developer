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
        float ResizeY(TextMeshProUGUI textComponent, RectTransform textRectTransform,
            RectTransform windowRectTransform, RectTransform scrollViewRectTransform);
        void Subscribe(ICalculatorObserver observer);
        void UnSubscribe(ICalculatorObserver observer);
    }
}
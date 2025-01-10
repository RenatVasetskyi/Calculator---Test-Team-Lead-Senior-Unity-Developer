using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Business.CalculatorProgram.Interfaces
{
    public interface ICalculatorView
    {
        TextMeshProUGUI ResultText { get; }
        string InputText { get; }
        Button ResultButton { get; }
        RectTransform Window { get; }
        RectTransform ScrollViewRectTransform { get; }
        void ShowResult(string result);
        void ShowCurrentInput(string input);
    }
}
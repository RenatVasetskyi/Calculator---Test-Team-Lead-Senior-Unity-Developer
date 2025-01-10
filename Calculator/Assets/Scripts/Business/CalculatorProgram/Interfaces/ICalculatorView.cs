using TMPro;
using UnityEngine.UI;

namespace Business.CalculatorProgram.Interfaces
{
    public interface ICalculatorView
    {
        TextMeshProUGUI ResultText { get; }
        string InputText { get; }
        Button ResultButton { get; }
        void ShowResult(string result);
        void ShowCurrentInput(string input);
    }
}
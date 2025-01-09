using UnityEngine.UI;

namespace CalculatorProgram.Interfaces
{
    public interface ICalculatorView
    {
        string InputText { get; }
        Button ResultButton { get; }
        void ShowResult(string result);
        void ShowError(string errorMessage);
    }
}
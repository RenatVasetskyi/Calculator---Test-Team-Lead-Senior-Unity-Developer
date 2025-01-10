using TMPro;
using UnityEngine;

namespace Business.CalculatorProgram.Interfaces
{
    public interface ITextResizer
    {
        void ChangeTextSizeY(TextMeshProUGUI textComponent, RectTransform rectTransform);
    }
}
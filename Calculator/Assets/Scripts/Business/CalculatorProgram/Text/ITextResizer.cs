using TMPro;
using UnityEngine;

namespace Business.CalculatorProgram.Interfaces
{
    public interface ITextResizer
    {
        float ChangeTextSizeY(TextMeshProUGUI textComponent, RectTransform rectTransform);
    }
}
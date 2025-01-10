using TMPro;
using UnityEngine;

namespace Business.CalculatorProgram.Resize.Interfaces
{
    public interface ITextResizer
    {
        float ChangeTextSizeY(TextMeshProUGUI textComponent, RectTransform rectTransform);
    }
}
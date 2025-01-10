using Business.CalculatorProgram.Interfaces;
using TMPro;
using UnityEngine;

namespace Business.CalculatorProgram.Text
{
    public class TextResizer : ITextResizer
    {
        public void ChangeTextSizeY(TextMeshProUGUI textComponent, RectTransform rectTransform)
        {
            Vector2 textSize = textComponent.GetPreferredValues();
            rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, textSize.y);
        }
    }
}
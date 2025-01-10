using Business.CalculatorProgram.Resize.Interfaces;
using TMPro;
using UnityEngine;

namespace Business.CalculatorProgram.Resize
{
    public class TextResizer : ITextResizer
    {
        public float ChangeTextSizeY(TextMeshProUGUI textComponent, RectTransform rectTransform)
        {
            Vector2 textSize = textComponent.GetPreferredValues();
            float oldSize = textComponent.rectTransform.sizeDelta.y;
            rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, textSize.y);
            rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x, -rectTransform.sizeDelta.y / 2);
            return rectTransform.sizeDelta.y - oldSize;
        }
    }
}
using Business.CalculatorProgram.Resize.Interfaces;
using UnityEngine;

namespace Business.CalculatorProgram.Resize
{
    public class RectTransformResizer : IRectTransformResizer
    {
        public float ResizeY(RectTransform window, float addY, Vector2 minSize, Vector2 maxSize)
        {
            Vector2 contentSize = window.sizeDelta;
            float oldHeight = contentSize.y;
            float newHeight = Mathf.Clamp(contentSize.y + addY, minSize.y, maxSize.y);
            window.sizeDelta = new Vector2(contentSize.x, newHeight);
            return newHeight - oldHeight;
        }
    }
}
using Business.CalculatorProgram.Resize.Interfaces;
using UnityEngine;

namespace Business.CalculatorProgram.Resize
{
    public class RectTransformResizer : IRectTransformResizer
    {
        private readonly Vector2 _minSize = new(800, 520);
        private readonly Vector2 _maxSize = new(1000, 1400);

        public float ResizeY(RectTransform window, float addY, Vector2 minSize, Vector2 maxSize)
        {
            Vector2 contentSize = window.sizeDelta;
            float oldHeight = contentSize.y;
            float newHeight = Mathf.Clamp(contentSize.y + addY, _minSize.y, _maxSize.y);
            window.sizeDelta = new Vector2(contentSize.x, newHeight);
            return newHeight - oldHeight;
        }
    }
}
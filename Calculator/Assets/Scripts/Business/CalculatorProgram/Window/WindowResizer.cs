using UnityEngine;

namespace Business.CalculatorProgram.Window
{
    public class WindowResizer : IWindowResizer
    {
        private readonly Vector2 _minSize = new(800, 520);
        private readonly Vector2 _maxSize = new(1000, 1400);

        public float ResizeY(RectTransform window, float addY)
        {
            Vector2 contentSize = window.sizeDelta;
            float oldHeight = contentSize.y;
            float newHeight = Mathf.Clamp(contentSize.y + addY, _minSize.y, _maxSize.y);
            window.sizeDelta = new Vector2(contentSize.x, newHeight);
            return newHeight - oldHeight;
        }
    }
}
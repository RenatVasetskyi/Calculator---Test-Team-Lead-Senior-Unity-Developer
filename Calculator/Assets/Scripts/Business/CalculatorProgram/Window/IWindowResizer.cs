using UnityEngine;

namespace Business.CalculatorProgram.Window
{
    public interface IWindowResizer
    {
        float ResizeY(RectTransform window, float addY);
    }
}
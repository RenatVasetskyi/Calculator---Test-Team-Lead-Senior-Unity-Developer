using UnityEngine;

namespace Business.CalculatorProgram.Resize.Interfaces
{
    public interface IRectTransformResizer
    {
        float ResizeY(RectTransform window, float addY, Vector2 minSize, Vector2 maxSize);
    }
}
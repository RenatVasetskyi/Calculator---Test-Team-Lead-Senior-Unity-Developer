using UnityEngine;

namespace Mono
{
    public class ClampScrollRect : MonoBehaviour
    {
        [SerializeField] private RectTransform _rectTransform;
        [SerializeField] private RectTransform _high;
        [SerializeField] private RectTransform _low;

        private void Update()
        {
            _rectTransform.anchorMin = new Vector2(_rectTransform.anchorMin.x, _low.anchorMin.y);
            _rectTransform.anchorMax = new Vector2(_rectTransform.anchorMax.x, _high.anchorMax.y);

            float height = _high.position.y - _low.position.y;
            _rectTransform.sizeDelta = new Vector2(_rectTransform.sizeDelta.x, height);
            _rectTransform.position = new Vector3(_rectTransform.position.x, _low.position.y + height / 2, _rectTransform.position.z);
        }
    }
}
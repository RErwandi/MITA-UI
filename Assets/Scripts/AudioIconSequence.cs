using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Mita
{
    public class AudioIconSequence : MonoBehaviour
    {
        private RectTransform rect;
        private Image image;

        private void Awake()
        {
            rect = GetComponent<RectTransform>();
            image = GetComponent<Image>();

            var randRot = Random.Range(-45f, 45f);
            
            image.DOFade(0f, 0f);
            image.DOFade(1f, 1f).SetEase(Ease.Linear);
            image.DOFade(0f, 1f).SetEase(Ease.Linear).SetDelay(2f);
            rect.DOScale(Vector3.zero, 0);
            rect.DOScale(Vector3.one, 0.5f).SetEase(Ease.Linear);
            rect.DOLocalRotate(new Vector3(0f, 0f, randRot), 0f);
            rect.DOLocalMove(new Vector3(0f, -30f), 0f);
            rect.DOLocalMove(new Vector3(-30f, 15f), 3f).SetEase(Ease.Linear);
            rect.DOLocalRotate(new Vector3(0f, 0f, -randRot), 3f).SetEase(Ease.Linear);
            rect.DOScale(Vector3.zero, 0.5f).SetDelay(2.5f).SetEase(Ease.Linear).OnComplete(delegate
            {
                Destroy(gameObject);
            });
        }
    }
}

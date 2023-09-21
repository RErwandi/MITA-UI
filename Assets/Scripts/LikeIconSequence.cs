using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Mita
{
    public class LikeIconSequence : MonoBehaviour
    {
        [SerializeField] private RectTransform activeLike;
        private Button button;
        private bool isActive;

        private void Awake()
        {
            button = GetComponent<Button>();
        }

        private void OnEnable()
        {
            button.onClick.AddListener(OnClick);
        }

        private void OnDisable()
        {
            button.onClick.RemoveListener(OnClick);
        }

        private void OnClick()
        {
            if (!isActive)
            {
                activeLike.DOScale(1f, 0.5f).SetEase(Ease.OutElastic);
                isActive = true;
            }
            else
            {
                activeLike.DOScale(0f, 0.5f).SetEase(Ease.InElastic);
                isActive = false;
            }
        }
    }
}

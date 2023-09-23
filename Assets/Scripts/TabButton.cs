using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Mita
{
    public class TabButton : MonoBehaviour
    {
        [SerializeField] private Button button;
        [SerializeField] private Image icon;
        [SerializeField] private TextMeshProUGUI text;
        [SerializeField] private Color activeColor = Color.white;
        [SerializeField] private Color inactiveColor = Color.white;

        private TabButtonGroup group;
        private int index;

        private void OnEnable()
        {
            button.onClick.AddListener(OnClick);
        }

        private void OnDisable()
        {
            button.onClick.RemoveListener(OnClick);
        }

        public void SetGroup(TabButtonGroup group, int index)
        {
            this.group = group;
            this.index = index;
        }
        
        public void Active()
        {
            if(icon != null)
                icon.color = activeColor;

            if (text != null)
                text.color = activeColor;
        }

        public void Inactive()
        {
            if(icon != null)
                icon.color = inactiveColor;

            if (text != null)
                text.color = inactiveColor;
        }

        private void OnClick()
        {
            group.OpenPanel(index);
        }
    }

}
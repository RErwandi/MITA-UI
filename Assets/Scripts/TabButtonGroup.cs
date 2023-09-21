using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mita
{
    public class TabButtonGroup : MonoBehaviour
    {
        [SerializeField] private List<TabButton> buttons = new();
        [SerializeField] private List<RectTransform> contents = new();

        private RectTransform currentContent;

        private void Start()
        {
            Initialize();
        }

        private void Initialize()
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].SetGroup(this, i);
            }
            
            ResetAll();
            OpenPanel(0);
        }

        private void ResetAll()
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Inactive();
                contents[i].gameObject.SetActive(false);
            }
        }

        public void OpenPanel(int index)
        {
            ResetAll();
            
            buttons[index].Active();
            contents[index].gameObject.SetActive(true);
        }
    }

}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mita
{
    public class AudioSpawner : MonoBehaviour
    {
        [SerializeField] private AudioIconSequence audioIcon;
        [SerializeField] private float interval;

        private void Start()
        {
            InvokeRepeating(nameof(Spawn), interval, interval);
        }

        private void Spawn()
        {
            Instantiate(audioIcon, transform);
        }
    }
}

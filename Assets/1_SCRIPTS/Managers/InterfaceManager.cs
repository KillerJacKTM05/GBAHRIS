using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SafeZone
{
    public class InterfaceManager : MonoBehaviour
    {
        public static InterfaceManager Instance { get; private set; }
        public void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(this);
            }
            else
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }

        }
        [Header("Main Canvas Groups")]
        public CanvasGroup m_gameGroup;
        public CanvasGroup m_menuGroup;

        [Header("Canvas Panels")]
        public CanvasGroup m_inventoryGroup;
        public CanvasGroup m_interactionGroup;
        public CanvasGroup m_inGameGroup;
        public CanvasGroup m_menuCanvasGroup;
        public CanvasGroup m_settingsGroup;
    }
}


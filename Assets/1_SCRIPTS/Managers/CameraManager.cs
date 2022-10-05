using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SafeZone
{
    public class CameraManager : MonoBehaviour
    {
        public static CameraManager Instance { get; private set; }
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
        [SerializeField] private Camera gameCamera;

        public Camera GetGameCamera()
        {
            return gameCamera;
        }
    }
}


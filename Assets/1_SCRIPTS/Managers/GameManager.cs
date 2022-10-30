using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SafeZone
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }
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
        [SerializeField] private GameSettings gameSettings;
        private LevelComponent activeLevel;
        private string currentTime = "08:00AM";
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {

        }
        public GameSettings GetGameSettings()
        {
            return gameSettings;
        }
        /*private IEnumerator GameDayCycle()
        {

        }*/
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Runner
{
    public class MusicSingleton : MonoBehaviour
    {
        private static MusicSingleton _instance;

        public static MusicSingleton instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = GameObject.FindObjectOfType<MusicSingleton>();
                    DontDestroyOnLoad(_instance.gameObject);
                }

                return _instance;
            }
        }

        void Awake()
        {
            if (_instance == null)
            {
                _instance = this;
                DontDestroyOnLoad(this);
            }
            else
            {
                if (this != _instance)
                {
                    Play();
                    Destroy(this.gameObject);
                }
            }

        }
        public void Update()
        {
            if (this != _instance)
            {
                _instance = null;
            }
        }
        public void Play()
        {
            this.gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
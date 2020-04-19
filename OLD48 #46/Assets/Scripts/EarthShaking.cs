using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthShaking : MonoBehaviour
{

    public AudioClip[] _clips;
    public Player _player;
    public int delayForNextEarthShaking;
    private float timer = 5;
    private AudioSource _as;

    public int targets;

    private void Start()
    {
        _as = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (timer < 0)
        {
            Shake();
            _as.clip = _clips[Random.Range(0, _clips.Length)];
            _as.Play();
            timer = delayForNextEarthShaking;
            delayForNextEarthShaking -= 1;
            if (targets < 7)
                targets += 1;
            if (delayForNextEarthShaking < 2)
                delayForNextEarthShaking = 2;
        }
        else
            timer -= Time.deltaTime;
    }

    void Shake()
    {
        _player.Shake();
        GameObject[] _objects = GameObject.FindGameObjectsWithTag("Building");
        for (int i = 0; i < targets; i++)
        {
            int index = Random.Range(0, _objects.Length);
            GameObject _object = _objects[index];
            _object.gameObject.GetComponent<BuildingState>().ChangeStatus(-1);
            _objects[index] = null;
            List<GameObject> gameObjectList = new List<GameObject>(_objects);
            gameObjectList.RemoveAll(x => x == null);
            _objects = gameObjectList.ToArray();
        }
    }
}

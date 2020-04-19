using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingState : MonoBehaviour
{
    public GameObject[] objects = new GameObject[4];
    public int status;
    private Vector3 startPos;

    private void Start()
    {
        startPos = gameObject.transform.position;
    }

    public void ChangeStatus(int _status)
    {
        status += _status;
    }

    private void Update()
    {
        ChangeMesh();
    }

    public void ChangeMesh()
    {
        switch (status)
        {
            case 0:
                Instantiate(objects[0], startPos, Quaternion.Euler(0f, 225f, 0f));
                GameOver.collapsed++;
                Destroy(gameObject);
                break;
            case 1:
                Instantiate(objects[1], startPos, Quaternion.Euler(0f, 225f, 0f));
                Destroy(gameObject);
                break;
            case 2:
                Instantiate(objects[2], startPos, Quaternion.Euler(0f, 225f, 0f));
                Destroy(gameObject);
                break;
            case 3:
                Instantiate(objects[3], startPos, Quaternion.Euler(0f, 225f, 0f));
                Destroy(gameObject);
                break;
        }
    }
}

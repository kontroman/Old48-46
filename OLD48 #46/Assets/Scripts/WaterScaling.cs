using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterScaling : MonoBehaviour
{

    public float speed;

    private float offset;

    private Vector3 StartingPos;

    private void Start()
    {
        offset = Random.Range(1.5f, 3f);
        StartingPos.y = transform.position.y;
    }

    private void Update()
    {
        gameObject.transform.position = new Vector3(transform.position.x, StartingPos.y + (Mathf.Sin(Time.time * speed)/ offset), transform.position.z);
    }


}

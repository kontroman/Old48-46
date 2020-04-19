using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Camera _camera;

    private void Start()
    {
        gameObject.GetComponent<Animation>().Play();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.gameObject);
                gameObject.GetComponent<AudioSource>().Play();
                hit.transform.gameObject.GetComponent<BuildingState>().ChangeStatus(1);
            }
        }
    }
    public void Shake()
    {
        Debug.Log("SHAKE");
        gameObject.GetComponent<Animation>().Play();
    }
}

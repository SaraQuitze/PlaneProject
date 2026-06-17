using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //asignar valor al offset haciendo un cálculo de la cámara respecto a la posición del avión
        if (offset == Vector3.zero)
        {
            offset = new Vector3(40f, 0, 0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
        transform.LookAt(plane.transform.position);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    public Transform target;
    //com de rapid es mou la camera
    public float smoothTime;    // Si ponemos 0 será como la cámara cutre
    Vector3 offset;
    Vector3 vel;    // Esto lo utiliza la función mágica del smooth
    // Start is called before the first frame update
    void Start()
    {
        //target player, transform camera
        offset = target.position - transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = target.position - offset;
        // Smoothly move the camera towards that target position, para que no siempre la personatge no es mou,sempre estar a la mateixa posicion
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref vel, smoothTime);
    }
}

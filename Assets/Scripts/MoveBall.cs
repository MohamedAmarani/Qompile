﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveBall : MonoBehaviour
{
    private bool pressedSpace = true;
    private float xSpeed = 20f, zSpeed = 20f;
    public Transform explosion;
    private int change = -1;
    public GameObject exploisionPrefab;
    public GameObject cambioExploisionPrefab;
    public GameObject choquePrefab;
    private Vector3 impulse = new Vector3(20.0f, 0.0f, 20.0f);
    private bool godMode = false;
    public ParticleSystem die;
    public AudioClip wallSound;
    public AudioClip paddleSound;
    public AudioClip dieSound;
    public AudioClip flagound;
    public AudioClip openSound;
    public GameObject barra;
    public Camera myCamera;
    private float timeToDie = 2000000.0f;
    private bool baja = false;
    private Vector3 previo;
    private int count = 0;
    private bool primero = false;
    private bool transporting = false;
    public GameObject godModeWord;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(20, 0, 20);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            godMode = !godMode;
            godModeWord.SetActive(godMode);
        }
    }
    void FixedUpdate()
    {
        if (!transporting)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(xSpeed, 0, zSpeed);
            /*if (Input.GetKey(KeyCode.UpArrow))
                transform.Translate(0, 1, 0);
            if (Input.GetKey(KeyCode.DownArrow))
                transform.Translate(0, -1, 0);
            if (Input.GetKey(KeyCode.LeftArrow))
                transform.Translate(-1, 0, 0);
            if (Input.GetKey(KeyCode.RightArrow))
                transform.Translate(1, 0, 0);*/

            if (baja)
            {
                gameObject.GetComponent<TrailRenderer>().emitting = true;
                ++count;
                if ((primero && count >= 30) || (!primero && count >= 12))
                {
                    primero = false;
                    GameObject pe;
                    pe = Instantiate(choquePrefab, previo, Quaternion.identity);
                    pe.GetComponent<MeshRenderer>().enabled = false;
                    count = 0;
                }
            }
            else
                gameObject.GetComponent<TrailRenderer>().emitting = false;

            if (count == 5)
            {
                previo = transform.position;
            }

            if (Input.GetKey(KeyCode.Space) && !pressedSpace)
            {
                pressedSpace = true;
                print("space");
                zSpeed *= (-1);
                GameObject p = Instantiate(cambioExploisionPrefab, gameObject.transform.position, Quaternion.identity);
            }
            else if (!Input.GetKey(KeyCode.Space))
                pressedSpace = false;

           /* if (Input.GetKeyDown(KeyCode.G))
            {
                godMode = !godMode;
                godModeWord.SetActive(godMode);
            }*/
        }
        else
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            transform.Translate(1, 0, 0);
        }
    }

    void OnParticleCollision(GameObject Other)
    {
            Destroy(gameObject);


        }


        void OnCollisionEnter(Collision collision)
    {

        GameObject p = Instantiate(exploisionPrefab, gameObject.transform.position, Quaternion.identity);
        p.transform.localScale = new Vector3(20, 20, 20);

        if (collision.collider.gameObject.name != "bricksInsPartes 12")
            Debug.Log(ReturnDirection(collision.gameObject, this.gameObject));

        if (collision.gameObject.tag == "danger")
        {
            AudioSource.PlayClipAtPoint(dieSound, myCamera.transform.position, 0.5f);
            if (!godMode)
            {
                die.Emit(42);
                die.transform.parent = null;
                Destroy(gameObject);
                //invocar esta funcion despues de 5s

            }

        }

        else if (collision.gameObject.tag == "end")
        {
            GameObject player = GameObject.Find("end");
            if (player)
            {
                AudioSource.PlayClipAtPoint(flagound, myCamera.transform.position, 5.0f);
                Destroy(player);
            }

        }

        else if (collision.gameObject.tag == "open")
        {
            Destroy(barra);
            GameObject player = GameObject.Find("open");
            if (player)
            {
                AudioSource.PlayClipAtPoint(openSound, myCamera.transform.position, 5.0f);
                Destroy(player);
            }
               
        }

        else if (collision.gameObject.tag == "paddle" || collision.gameObject.tag == "barra")
            AudioSource.PlayClipAtPoint(paddleSound, myCamera.transform.position, 7.0f);
        else if(collision.gameObject.tag == "paddleSpecial")
        {
            AudioSource.PlayClipAtPoint(paddleSound, myCamera.transform.position, 7.0f);
            barra.SetActive(true);
        }
        else
            AudioSource.PlayClipAtPoint(wallSound, myCamera.transform.position, 0.2f);

        if (collision.collider.gameObject.name == "choque")
        {
            primero = true;
            baja = true;
        }

        if (collision.collider.gameObject.name == "ChoqueSave")
        {
            baja = false;

        }

        if (collision.collider.gameObject.name == "bricksInsPartes 3 1(Clone)")
        {
            AudioSource.PlayClipAtPoint(dieSound, myCamera.transform.position, 0.5f);
            if (!godMode)
            {
                die.Emit(42);
                die.transform.parent = null;
                Destroy(gameObject);
                //invocar esta funcion despues de 5s

            }
            //Destroy(gameObject);
        }

        if (collision.gameObject.tag == "mecanica3")
        {
            transporting = true;
        }
        else
            transporting = false;

    }

    private enum HitDirection { None, Top, Bottom, Forward, Back, Left, Right }
    private HitDirection ReturnDirection(GameObject Object, GameObject ObjectHit)
    {

        HitDirection hitDirection = HitDirection.None;
        RaycastHit MyRayHit;
        Vector3 direction = (Object.transform.position - ObjectHit.transform.position).normalized;
        Ray MyRay = new Ray(ObjectHit.transform.position, direction);

        if (Physics.Raycast(MyRay, out MyRayHit))
        {

            if (MyRayHit.collider != null)
            {

                Vector3 MyNormal = MyRayHit.normal;
                MyNormal = MyRayHit.transform.TransformDirection(MyNormal);

                if (MyNormal == MyRayHit.transform.up) { hitDirection = HitDirection.Top; zSpeed = 20; }
                if (MyNormal == -MyRayHit.transform.up) { hitDirection = HitDirection.Bottom; zSpeed = -20; }
                if (MyNormal == MyRayHit.transform.forward) { hitDirection = HitDirection.Forward; zSpeed = 20; }
                if (MyNormal == -MyRayHit.transform.forward) { hitDirection = HitDirection.Back; zSpeed = -20; }
                if (MyNormal == MyRayHit.transform.right) { hitDirection = HitDirection.Right; xSpeed = 20; }
                if (MyNormal == -MyRayHit.transform.right) { hitDirection = HitDirection.Left; xSpeed = -20; }
            }
        }
        return hitDirection;
    }

}
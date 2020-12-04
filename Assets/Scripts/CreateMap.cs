using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMap : MonoBehaviour
{
    public GameObject whiteCube;
    public GameObject whiteBlackCube;
    private float lastX = 9, lastZ = 2, y = 10.5f;
    private float blastX = 9, blastZ = -6;
    private float size = 5.001f;
    // Start is called before the first frame update
    void Start()
    {
        //creating map
        for (int i = 0; i < 8; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(lastX, y, lastZ += size), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        //by
        for (int i = 0; i < 8; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(blastX, y, blastZ -= size), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        for (int i = 0; i < 25; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(lastX += size, y, lastZ), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        //bx
        for (int i = 0; i < 25; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(blastX += size, y, blastZ), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }

        for (int i = 0; i < 6; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(lastX, y, lastZ -= size), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        //by
        for (int i = 0; i < 6; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(blastX, y, blastZ += size), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        for (int i = 0; i < 10; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(lastX += size, y, lastZ), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        //bx
        for (int i = 0; i < 10; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(blastX += size, y, blastZ), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        for (int i = 0; i < 17; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(lastX, y, lastZ += size), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        //by
        for (int i = 0; i < 15; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(blastX, y, blastZ -= size), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        //bx
        for (int i = 0; i < 4; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(blastX += size, y, blastZ), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        //by
        for (int i = 0; i < 4; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(blastX, y, blastZ -= size), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        //bx
        for (int i = 0; i < 4; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(blastX -= size, y, blastZ), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        //by
        for (int i = 0; i < 21; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(blastX, y, blastZ -= size), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        for (int i = 0; i < 27; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(lastX += size, y, lastZ), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        //bx
        for (int i = 0; i < 27; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(blastX += size, y, blastZ), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        for (int i = 0; i < 14; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(lastX, y, lastZ -= size), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        //by
        for (int i = 0; i < 21; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(blastX, y, blastZ += size), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        //bx
        for (int i = 0; i < 4; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(blastX -= size, y, blastZ), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        //by
        for (int i = 0; i < 4; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(blastX, y, blastZ += size), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        //bx
        for (int i = 0; i < 4; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(blastX += size, y, blastZ), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        //by
        for (int i = 0; i < 16; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(blastX, y, blastZ += size), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        for (int i = 0; i < 33; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(lastX += size, y, lastZ), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        //bx
        for (int i = 0; i < 17; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(blastX += size, y, blastZ), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        //by
        for (int i = 0; i < 21; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(blastX, y, blastZ -= size), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        //bx
        for (int i = 0; i < 28; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(blastX += size, y, blastZ), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        for (int i = 0; i < 27; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(lastX, y, lastZ -= size), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        for (int i = 0; i < 5; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(lastX += size, y, lastZ), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        for (int i = 0; i < 80; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(lastX, y, lastZ += size), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        //by
        for (int i = 0; i < 90; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(blastX, y, blastZ += size), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        for (int i = 0; i < 8; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(lastX -= size, y, lastZ), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        //bx
        for (int i = 0; i < 34; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(blastX -= size, y, blastZ), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        for (int i = 0; i < 18; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(lastX, y, lastZ -= size), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        for (int i = 0; i < 22; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(lastX -= size, y, lastZ), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }
        for (int i = 0; i < 14; ++i)
        {
            GameObject obj = (GameObject)Instantiate(whiteCube, new Vector3(lastX, y, lastZ += size), transform.rotation);
            obj.transform.parent = gameObject.transform;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
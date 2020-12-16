using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMap2 : MonoBehaviour
{
    public GameObject redCube;
    public GameObject blueCube;
    public GameObject yellowCube;
    public GameObject greenCube;
    public GameObject groundCube;
    private float lastX = 9, lastZ = 2, y = 9.28f;
    private float blastX = 9, blastZ = -6;
    private float size = 5.001f;
    // Start is called before the first frame update

    void Start()
    {
        //creating map
        //crear suelo
        for (int i = -70; i < 130; ++i)
            for (int j = -20; j < 40; ++j)
            {
                GameObject obj = (GameObject)Instantiate(groundCube, new Vector3(i * 5.0f, 8.0f, -230 + j * 8.7f), Quaternion.Euler(90.0f, -90.0f, -180.0f));
                obj.transform.parent = gameObject.transform;
            }

        lastX -= 45.0f;
        for (int i = 0; i < 44; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        lastZ += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        lastZ += 2.5f;
        for (int i = 0; i < 2; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        lastZ += 2.5f;
        for (int i = 0; i < 12; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        float aux = lastX;
        lastX += 2.5f;
        for (int i = 0; i < 5; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        lastX = aux;
        lastZ += 2.5f;
        for (int i = 0; i < 12; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        lastX += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        lastZ += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        lastX += 2.5f;
        for (int i = 0; i < 33; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        lastZ += 2.5f;
        for (int i = 0; i < 3; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        lastZ += 2.5f;
        for (int i = 0; i < 3; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        lastZ += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        lastZ += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        for (int i = 0; i < 10; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 5; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 5; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        lastZ += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        lastZ += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        lastZ += 2.5f;
        for (int i = 0; i < 2; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        lastZ += 2.5f;
        for (int i = 0; i < 10; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        lastX += 2.5f;
        for (int i = 0; i < 2; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        lastZ += 2.5f;
        for (int i = 0; i < 4; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        lastX += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        lastZ += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        lastX += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        lastZ += 2.5f;
        for (int i = 0; i < 5; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        lastZ += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        for (int i = 0; i < 11; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }


        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }


        for (int i = 0; i < 2; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 5; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 5; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 31; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 32; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        lastZ += 2.5f;
        for (int i = 0; i < 10; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        lastX += 2.5f;
        for (int i = 0; i < 5; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        lastZ += 2.5f;
        for (int i = 0; i < 4; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        lastZ += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        lastZ += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        lastZ += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        lastZ += 2.5f;
        for (int i = 0; i < 5; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        lastX += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        lastZ += 2.5f;
        for (int i = 0; i < 2; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        lastX += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        lastZ += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        lastX += 2.5f;
        for (int i = 0; i < 3; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        lastZ += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        lastX += 2.5f;
        for (int i = 0; i < 6; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        lastX += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        lastX += 2.5f;
        for (int i = 0; i < 2; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        for (int i = 0; i < 2; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        lastX += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        for (int i = 0; i < 5; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 2; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 4; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        lastX += 2.5f;
        for (int i = 0; i < 6; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        lastZ += 2.5f;
        for (int i = 0; i < 30; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        lastX += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        lastZ += 2.5f;
        for (int i = 0; i < 3; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        lastX += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        lastZ += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        lastX += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        lastZ += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        lastX += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        lastZ += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        lastX += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        lastZ += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ -= size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ -= 2.5f;

        lastX += 2.5f;
        for (int i = 0; i < 34; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        lastX += 2.5f;
        for (int i = 0; i < 2; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        lastX += 2.5f;
        for (int i = 0; i < 2; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        for (int i = 0; i < 2; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        lastX += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        lastX += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        for (int i = 0; i < 3; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        lastX += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        for (int i = 0; i < 2; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 4; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 3; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 4; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 3; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        lastX += 2.5f;
        for (int i = 0; i < 15; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        lastX += 2.5f;
        for (int i = 0; i < 2; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        lastX += 2.5f;
        for (int i = 0; i < 5; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        lastX += 2.5f;
        for (int i = 0; i < 2; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        lastX += 2.5f;
        for (int i = 0; i < 2; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        lastX += 2.5f;
        for (int i = 0; i < 2; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        lastX += 2.5f;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        for (int i = 0; i < 11; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }
        aux = lastZ;
        for (int i = 0; i < 3; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastZ = aux;

        lastX -= 15.0f;
        lastX += 2.5f;
        for (int i = 0; i < 4; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX -= size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX -= 2.5f;

        for (int i = 0; i < 28; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(lastX, y + j * 2.4f, j == 0 ? lastZ += size : lastZ), transform.rotation * Quaternion.Euler(90f, 0, 0));
                obj.transform.parent = gameObject.transform;
            }
        }

        aux = lastX;
        for (int i = 0; i < 1; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
        lastX = aux;

        lastZ -= 75.0f;
        for (int i = 0; i < 21; ++i)
        {
            GameObject obj;
            int b = Random.Range(1, 6);
            for (int j = 0; j < b; ++j)
            {
                int a = Random.Range(0, 4);
                if (a == 0)
                    obj = (GameObject)Instantiate(redCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 1)
                    obj = (GameObject)Instantiate(blueCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else if (a == 2)
                    obj = (GameObject)Instantiate(yellowCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                else
                    obj = (GameObject)Instantiate(greenCube, new Vector3(j == 0 ? lastX += size : lastX, y + j * 2.4f, lastZ), transform.rotation);
                obj.transform.parent = gameObject.transform;
            }
        }
    }



    // Update is called once per frame
    void Update()
    {

    }
}
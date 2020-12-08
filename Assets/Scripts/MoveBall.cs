using System.Collections;
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
    private Vector3 impulse = new Vector3(20.0f, 0.0f, 20.0f);
    private bool godMode = false;
    public ParticleSystem die;

    // Start is called before the first frame update
    void Start()
    {
        // GetComponent<Rigidbody>().AddForce(impulse, ForceMode.Impulse);
        GetComponent<Rigidbody>().velocity = new Vector3(20, 0, 20);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(xSpeed, 0, zSpeed);

        if (Input.GetKey(KeyCode.Space) && !pressedSpace)
          {
            pressedSpace = true;
            print("space");
            zSpeed *= (-1);
            GameObject p = Instantiate(cambioExploisionPrefab, gameObject.transform.position, Quaternion.identity);
        }
          else if (!Input.GetKey(KeyCode.Space))
            pressedSpace = false;

        if (Input.GetKeyDown(KeyCode.G) && !godMode)
        {
            godMode = true;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject p = Instantiate(exploisionPrefab, gameObject.transform.position, Quaternion.identity);
        p.transform.localScale = new Vector3(20, 20, 20);
        Debug.Log(ReturnDirection(collision.gameObject, this.gameObject));
        if(collision.gameObject.tag == "danger")
        {
            if(!godMode)
            {
                die.Emit(42);
                die.transform.parent = null;
                Destroy(gameObject);
                //invocar esta funcion despues de 5s
                
            }

        }
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
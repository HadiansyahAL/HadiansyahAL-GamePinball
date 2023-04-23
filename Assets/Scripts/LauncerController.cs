using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncerController : MonoBehaviour
{
    public Collider ball;
    public KeyCode input;
    private Renderer renderer;
    public Material onMaterial;
    public Material offMaterial;
    public float maxTimeHold;
    public float Maxforce;
    private bool isHold = false;
   

   private void Start() {
        renderer = GetComponent<Renderer>();
   }

   private void  OnCollisionStay(Collision collision) {
        if (collision.collider == ball)
        {
            ReadInput(ball);
           
        }
   }

   private void ReadInput(Collider collider)
   {
        if (Input.GetKey(input) && !isHold )
        {
             StartCoroutine(StartHold(collider));
             
        }
   }

   private IEnumerator StartHold(Collider collider)
   {
        isHold = true;
        float force = 0.0f;
        float timeHold = 0.0f;
            
        while (Input.GetKey(input))
        {
            force = Mathf.Lerp(0, Maxforce, timeHold/maxTimeHold);

            yield return new WaitForEndOfFrame();
            timeHold += Time.deltaTime;
            renderer.material = onMaterial;
        }

        collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        isHold = false;
        renderer.material = offMaterial;
   }
}

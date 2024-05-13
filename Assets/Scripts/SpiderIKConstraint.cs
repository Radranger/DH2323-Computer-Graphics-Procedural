using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderProceduralAnimation : MonoBehaviour
{     
    int layerMask;
    public GameObject Target;
    Vector3 currentPosition;
    public float stepDistance = 1.5f;

    private void Start()
    {
        currentPosition = transform.position;
        //layerMask = LayerMask.GetMask("floor"); // A layer mask so that a ray can be cast just at gameobjects on the Floor layer.

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = currentPosition;
            if (Vector3.Distance(Target.transform.position, currentPosition) > stepDistance)
            {
                //Debug.Log(Vector3.Distance(hit.point, currentPosition));
                // Move the bone's position to the hit point
                currentPosition = Target.transform.position;  
            }
    }

    /*void Update()
        {
            Ray ray = new Ray(body.position + (body.right * footSpacing), Vector3.down);
            if (Physics.Raycast(ray, out RaycastHit info, 10, terrainLayer.value))
            {
                transform.position = info.point;
            }
        }
    
    Vector3 currentPosition, newPosition, targetPosition, bodyPosition;
    public float stepDistance = 1.5f;
    public GameObject Target;
    //public GameObject[] targetArray;
    private float distanceToNearest;

    void Update()
    {
        transform.position = currentPosition;
        Ray rayTarget = new Ray(Target.transform.position, Vector3.down);
        if (Physics.Raycast(rayTarget, out RaycastHit info, 10))
        {
            if (Vector3.Distance(Target.transform.position, currentPosition) > stepDistance)
            {
            //Debug.Log(Vector3.Distance(hit.point, currentPosition));
            // Move the bone's position to the hit point
            currentPosition = Target.transform.position;
            }
        }
        */
}

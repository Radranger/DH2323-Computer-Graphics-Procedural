using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderProceduralAnimation : MonoBehaviour
{
    //private LayerMask floorLayer = default;        
    // A layer mask so that a ray can be cast just at gameobjects on the ground layer.
    Vector3 currentPosition, newPosition, targetPosition, bodyPosition;
    public float stepDistance = 1.5f;
    public GameObject Target;
    //public GameObject[] targetArray;
    private float distanceToNearest;

    private void Start()
    {
        currentPosition = newPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = currentPosition;
        /*targetArray = GameObject.FindGameObjectsWithTag("Target");
        GameObject Target = targetArray[0];
        distanceToNearest = Vector3.Distance(currentPosition, Target.transform.position);
        for (int i = 1; i < targetArray.Length; i++)
        {
            float distanceToCurrent = Vector3.Distance(currentPosition, targetArray[i].transform.position);
            if (distanceToCurrent < distanceToNearest)
            {
                Target = targetArray[i];
            }
        }
        */
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
    }

    void onDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(newPosition, 0.5f);
    }

    /*void Update()
        {
            Ray ray = new Ray(body.position + (body.right * footSpacing), Vector3.down);
            if (Physics.Raycast(ray, out RaycastHit info, 10, terrainLayer.value))
            {
                transform.position = info.point;
            }
        }*/
}

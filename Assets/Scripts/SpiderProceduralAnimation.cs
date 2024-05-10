using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderProceduralAnimation : MonoBehaviour
{
    //private LayerMask floorLayer = default;        // A layer mask so that a ray can be cast just at gameobjects on the ground layer.
    Vector3 currentPosition, newPosition, oldPosition;

    private void Start()
    {
        currentPosition = newPosition = oldPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = currentPosition;

        Ray ray = new Ray(currentPosition, Vector3.down);
        if (Physics.Raycast(ray, out RaycastHit hit, 10))
        {
            //Debug.Log("Floor Hit!");
            // Move the bone's position to the hit point
            
            newPosition = hit.point;
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderProceduralAnimation : MonoBehaviour
{
    //private LayerMask floorLayer = default;        // A layer mask so that a ray can be cast just at gameobjects on the ground layer.
    Vector3 currentPosition, newPosition, targetPosition, bodyPosition;
    public float stepDistance = 1f;
    public GameObject Target;

    private void Start()
    {
        currentPosition = newPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = currentPosition;
        targetPosition = GameObject.FindWithTag("Target").transform.position;
        Ray ray = new Ray(targetPosition, Vector3.down);
        if (Physics.Raycast(ray, out RaycastHit hit, 10))
        {
            if (Vector3.Distance(targetPosition, currentPosition) > stepDistance)
            {
            Debug.Log(Vector3.Distance(hit.point, currentPosition));
            // Move the bone's position to the hit point
            currentPosition = hit.point;
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

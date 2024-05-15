using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderOppositeIKConstraint : MonoBehaviour
{
    int layerMask;
    public GameObject Target;
    public GameObject oppositeTarget;
    public GameObject legs;
    public Vector3 currentPosition;
    public float stepDistance = 1.5f;
    public float legSpeed = 10f;
    public bool hasMoved;

    private void Start()
    {
        currentPosition = transform.position;
        //layerMask = LayerMask.GetMask("floor"); // A layer mask so that a ray can be cast just at gameobjects on the Floor layer.
        hasMoved = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = currentPosition;
            if (Vector3.Distance(Target.transform.position, currentPosition) > stepDistance && hasMoved == false)
            {
                hasMoved = true;
                //Debug.Log(Vector3.Distance(hit.point, currentPosition));
                // Move the bone's position to the hit point
                if (hasMoved == true)
                {
                    Debug.Log(hasMoved);
                    currentPosition = Target.transform.position;
                    legs.GetComponent<SpiderIKConstraint>().hasMoved = false;
                    //legs[1].GetComponent<SpiderIKConstraint>().hasMoved = false;
                }
            }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderOppositeIKConstraint : MonoBehaviour
{
    int layerMask;
    public GameObject Target;
    public GameObject oppositeTarget;
    public GameObject[] legs;
    public Vector3 currentPosition;
    public float stepDistance = 1.5f;
    public float legSpeed = 10f;
    public bool hasMoved;
    public SpiderIKConstraint Leg;

    private void Start()
    {
        legs = GameObject.FindGameObjectsWithTag("Leg");
        currentPosition = transform.position;
        //layerMask = LayerMask.GetMask("floor"); // A layer mask so that a ray can be cast just at gameobjects on the Floor layer.
        hasMoved = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = currentPosition;
            if (Vector3.Distance(Target.transform.position, currentPosition) > stepDistance)
            {
                //Debug.Log(Vector3.Distance(hit.point, currentPosition));
                // Move the bone's position to the hit point
                if (hasMoved == false);
                {
                    currentPosition = Target.transform.position;
                    Leg.currentPosition = oppositeTarget.transform.position;
                    legs[0].GetComponent<SpiderIKConstraint>().hasMoved = false;
                    legs[1].GetComponent<SpiderIKConstraint>().hasMoved = false;
                }
            }
    }
}

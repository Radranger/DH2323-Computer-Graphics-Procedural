using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderIKConstraint : MonoBehaviour
{     
    int layerMask;
    public GameObject Target;
    public GameObject oppositeTarget;
    public GameObject oppositeLegs;
    public Vector3 currentPosition;
    public Vector3 oppositeLegPosition;
    public float stepDistance = 1.5f;
    public float legSpeed = 10f;
    private float stepCounter = 0f;
    public bool hasMoved;

    private void Start()
    {
        currentPosition = transform.position;
        oppositeLegPosition = oppositeLegs.transform.position;
        //layerMask = LayerMask.GetMask("floor"); // A layer mask so that a ray can be cast just at gameobjects on the Floor layer.
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = currentPosition;
        oppositeLegs.transform.position = oppositeLegPosition;
        if (Vector3.Distance(Target.transform.position, currentPosition) > stepDistance && stepCounter %2 != 0)
        {
            //Debug.Log(Vector3.Distance(hit.point, currentPosition));
            // Move the bone's position to the hit point
            Debug.Log(hasMoved);
            stepCounter = 0;
            oppositeLegPosition = oppositeTarget.transform.position;

            //oppositeLegs[1].GetComponent<SpiderOppositeIKConstraint>().hasMoved = false;
        }
        else if (Vector3.Distance(oppositeTarget.transform.position, oppositeLegPosition) > stepDistance && stepCounter %2 == 0)
        {
            currentPosition = Target.transform.position;
            stepCounter = 1;
        }
    }

            /*
            else
            {
                isMoving = true;
                hasMoved = false;
                currentPosition = Vector3.Lerp(currentPosition, Target.transform.position, Time.deltaTime * legSpeed);  
            }
            
            if (isMoving == true)
            {

            }
            */

        //BACKUP CODE BELOW

        /*
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

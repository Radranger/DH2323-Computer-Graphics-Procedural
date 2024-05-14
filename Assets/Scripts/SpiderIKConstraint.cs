using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderIKConstraint : MonoBehaviour
{     
    int layerMask;
    public GameObject Target;
    public GameObject oppositeTarget;
    public GameObject[] oppositeLegs;
    public Vector3 currentPosition;
    public float stepDistance = 1.5f;
    public float legSpeed = 10f;
    public bool hasMoved;
    public SpiderOppositeIKConstraint oppositeLeg;

    private void Start()
    {
        oppositeLegs = GameObject.FindGameObjectsWithTag("OppositeLeg");
        currentPosition = transform.position;
        //layerMask = LayerMask.GetMask("floor"); // A layer mask so that a ray can be cast just at gameobjects on the Floor layer.
        hasMoved = false;
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
                    oppositeLeg.currentPosition = oppositeTarget.transform.position;
                    oppositeLegs[0].GetComponent<SpiderOppositeIKConstraint>().hasMoved = false;
                    oppositeLegs[1].GetComponent<SpiderOppositeIKConstraint>().hasMoved = false;
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
    }
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

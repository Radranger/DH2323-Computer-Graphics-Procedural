using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderTargetConstraint : MonoBehaviour
{
    int layerMask;
    // Start is called before the first frame update
    void Start()
    {
        layerMask = LayerMask.GetMask("Floor");
    }

    // Update is called once per frame
    void Update()
    {
        Ray rayTarget = new Ray(transform.position + new Vector3(0f, 0.05f, 0f), Vector3.down); // raised the position vector in the y direction slightly, otherwise there is a risk that it will go under the plane if another game object (like parts of the sphere) is under it.
        if (Physics.Raycast(rayTarget, out RaycastHit hit, Mathf.Infinity, layerMask))
        {
            //Debug.Log(Vector3.Distance(hit.point, currentPosition));
            // Move target's position according to the hit point
            transform.position = hit.point;
        }
    }
}

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
        Ray rayTarget = new Ray(transform.position + new Vector3(0f, 0.05f, 0f), Vector3.down);
        if (Physics.Raycast(rayTarget, out RaycastHit hit, Mathf.Infinity, layerMask))
        {
            //Debug.Log(Vector3.Distance(hit.point, currentPosition));
            // Move target's position according to the hit point
            transform.position = hit.point + new Vector3(0f, 0.01f, 0f);
        } 
    }
}

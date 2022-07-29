using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform target;
    public float distance = 10;

    private Transform targetOld;
    private float distanceOld;

    // Start is called before the first frame update
    void Start()
    {
        targetOld = null;
        distanceOld = 0;
    }

    // Update is called once per frame
    void Update()
    {
        var changeTarget = targetOld == null || !(targetOld.position.Equals(target.position));

        // Rotate the camera every frame so it keeps looking at the target
        if (changeTarget)
        {
            transform.LookAt(target);
            targetOld = target;
        }

        // Same as above, but setting the worldUp parameter to Vector3.left in this example turns the camera on its side
        //transform.LookAt(target, Vector3.left);

        var wheel = -Input.mouseScrollDelta.y;

        if (wheel < 0)
        {
            distance += wheel;
            if (distance < 1)
                distance = 1;
        }
        else if (wheel > 0)
        {
            distance += wheel;
        }

        if (changeTarget || distance != distanceOld)
        {
            //var diff = target.position - ((target.position - this.transform.position).normalized * distance);

            //transform.Translate(diff);
            transform.Translate((target.position - this.transform.position).normalized * distance);
            distanceOld = distance;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform target;
    public float distance = 10;

    private bool distChange = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the camera every frame so it keeps looking at the target
        transform.LookAt(target);

        // Same as above, but setting the worldUp parameter to Vector3.left in this example turns the camera on its side
        //transform.LookAt(target, Vector3.left);

        var wheel = -Input.mouseScrollDelta.y;

        if (wheel < 0)
        {
            distance += wheel;
            if (distance < 1)
                distance = 1;
            distChange = true;
        }
        else if (wheel > 0)
        {
            distance += wheel;
            distChange = true;
        }

        if (distChange)
        {
            var diff = target.position - ((target.position - this.transform.position).normalized * distance);

            transform.Translate(diff);
            distChange = false;
        }
    }
}

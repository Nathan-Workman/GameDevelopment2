using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform target;        //Adds a Input feild in inspector to add an object into the script

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.position;
    }
}

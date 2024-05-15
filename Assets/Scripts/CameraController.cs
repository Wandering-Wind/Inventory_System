using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public void leftButton()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    public void rightButton()
    {
        transform.position = new Vector3(10f, 0, 0);
    }
}

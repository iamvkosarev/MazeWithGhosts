using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour
{
    public BaseMove playerBaseMove { set; get; }

    private void FixedUpdate()
    {

        playerBaseMove?.Move(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")));
    }
    private void Update()
    {
        playerBaseMove?.Rotation(new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")));

    }
}

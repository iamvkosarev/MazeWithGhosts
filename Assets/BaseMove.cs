using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public abstract class BaseMove : MonoBehaviour
{
    [SerializeField] protected Rigidbody mover;
    [SerializeField] protected float moveSpeed;
    [SerializeField] protected float rotationSpeed;
    public abstract void Move(Vector3 direction);

    public void Rotation(Vector3 direction)
    {
        if(direction.magnitude > 0.2f)
            transform.eulerAngles = new Vector3(0f,Mathf.Atan2(direction.x, direction.z) * 180f / Mathf.PI,0f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 0f;
    private Vector3 target = new Vector3(0f,0f,0f);

    public Vector3 Target
    {
        set
        {
            target = value;
        }
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, moveSpeed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateAll : MonoBehaviour
{
    public float rotateY = 0f;
    public float rotateX = 0f;
    public float rotateSpeed = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetKeyDown(KeyCode.D)) {
			rotateY = rotateY - (float)rotateSpeed;
		} 
	if (Input.GetKeyDown(KeyCode.A)) {
			rotateY = rotateY + (float)rotateSpeed;
		}
    if (Input.GetKeyDown(KeyCode.S)) {
			rotateX = rotateX - (float)rotateSpeed;
		} 
	if (Input.GetKeyDown(KeyCode.W)) {
			rotateX = rotateX + (float)rotateSpeed;
		}

    transform.Rotate(rotateX, rotateY, 0, Space.World);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMoveScript : MonoBehaviour
{

    public float moveSpeed = 1;
    public float deadZone = -20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime; 

        if (transform.position.x < deadZone) {
            Debug.Log("Pipe Deleted at dead zone: " + deadZone);
            Destroy(gameObject);
        }
    }
}

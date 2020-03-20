using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballscript : MonoBehaviour
{
    public int speed=30;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Heloo World!");
        GetComponent<Rigidbody2D>().velocity = new Vector2(1,-1)*speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

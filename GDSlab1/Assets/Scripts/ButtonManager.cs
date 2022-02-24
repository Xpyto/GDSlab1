using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D)){
            transform.Translate(new Vector3(1,0,0) * speed * Time.deltaTime);
        }else if(Input.GetKey(KeyCode.A)){
            transform.Translate(new Vector3(-1,0,0) * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.W)){
            transform.Translate(new Vector3(0,1,0) * speed * Time.deltaTime);
        }else if(Input.GetKey(KeyCode.S)){
            transform.Translate(new Vector3(0,-1,0) * speed * Time.deltaTime);
        }
    }
}

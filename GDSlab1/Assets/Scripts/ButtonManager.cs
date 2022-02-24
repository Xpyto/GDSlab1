using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public float speed = 2;
    int OnHeli;
    // Start is called before the first frame update
    void Start()
    {
        OnHeli = 0;
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

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Collision");
        if(other.tag == "soldier" && OnHeli < 3){
            Destroy(other.gameObject);
            OnHeli++;
        }
    }
}

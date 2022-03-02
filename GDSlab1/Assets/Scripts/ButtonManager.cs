using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonManager : MonoBehaviour
{
    public float speed = 2;
    public Text soldierScore;
    int soldierScoreNum;
    public Text soldierCarry;
    int OnHeli;
    bool dead;
    public Text gameOver;

    // Start is called before the first frame update
    void Start()
    {
        OnHeli = 0;
        soldierScoreNum = 0;
        dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!dead)
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);
            }

            soldierCarry.text = "Soldiers in Helicopter: " + OnHeli.ToString();
            soldierScore.text = "Soldiers in Hospital: " + soldierScoreNum.ToString();

        }
        else
        {
            if (gameOver)
            {
                gameOver.gameObject.SetActive(true);
            }
        }

        }

        private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Collision");
        if(other.tag == "soldier" && OnHeli < 3){
            Destroy(other.gameObject);
            OnHeli++;
        }else if(other.tag == "tree")
        {
            dead = true;
        }
    }
}

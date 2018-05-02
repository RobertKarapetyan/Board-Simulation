using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int numOfCollisions;
    public float speed;
    public Text countTextRef;
    public Text winTextRef;

    private Rigidbody rigidBody;
    private int count;

    private void Awake()
    {
        this.countTextRef = GameObject.Find("Count Text").
            GetComponent<Text>();
        this.winTextRef = GameObject.Find("Win Text").
            GetComponent<Text>();
        this.count = 0;
        this.numOfCollisions = 4;
    }

    private void FixedUpdate()
    {
        this.GetComponent<Rigidbody>().AddForce(new Movement().getForce() * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count++;
            this.UpdateCountText();
        }           
    }

    private void UpdateCountText()
    {
        this.countTextRef.text = "Count: " + count.ToString();
        if (this.count == this.numOfCollisions)
            winTextRef.text = "You Win!";
    }
}
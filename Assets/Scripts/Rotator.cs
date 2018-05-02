using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Collider coll;

    private void Awake()
    {
        coll = this.GetComponent<Collider>();
    }

    void Start()
    {
        this.coll.isTrigger = true;
        this.GetComponent<Rigidbody>().useGravity = true;
        this.GetComponent<Rigidbody>().isKinematic = true;
    }

    void Update ()
    {
        this.transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}
}

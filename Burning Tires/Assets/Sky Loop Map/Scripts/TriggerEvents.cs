using UnityEngine;
using System.Collections;

public class TriggerEvents : MonoBehaviour
{
    public GameObject BoulderOne;
    public GameObject BoulderTwo;
    public GameObject BoulderThree;
    public GameObject BoulderFour;
    private Rigidbody rb1;
    private Rigidbody rb2;
    private Rigidbody rb3;
    private Rigidbody rb4;

    void Start()
    {
        rb1 = BoulderOne.GetComponent<Rigidbody>();
        rb2 = BoulderTwo.GetComponent<Rigidbody>();
        rb3 = BoulderThree.GetComponent<Rigidbody>();
        rb4 = BoulderFour.GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.name == "BoulderTrigger")
        {
            rb1.isKinematic = false;
            rb2.isKinematic = false;
            rb3.isKinematic = false;
            rb4.isKinematic = false;
        }
    }
}

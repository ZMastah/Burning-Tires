using UnityEngine;
using System.Collections;

public class CheckpointTrigger : MonoBehaviour {

    public Material greenMat;
    public Material redMat;
    public Material blackMat;
    private GameObject[] allCheckpoints;
	void Start () {
        allCheckpoints = GameObject.FindGameObjectsWithTag("CheckPoint");
	}

    void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.name == "CheckpointPanel")
        {
            for (var i = 0; i < allCheckpoints.Length; i++)
            {
                allCheckpoints[i].transform.GetChild(1).gameObject.GetComponent<MeshRenderer>().material = redMat;
                allCheckpoints[i].transform.GetChild(2).gameObject.GetComponent<MeshRenderer>().material = blackMat;
            }
            coll.transform.GetChild(1).gameObject.GetComponent<MeshRenderer>().material = blackMat;
            coll.transform.GetChild(2).gameObject.GetComponent<MeshRenderer>().material = greenMat;
        }
    }
}

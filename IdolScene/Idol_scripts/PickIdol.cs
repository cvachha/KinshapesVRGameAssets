using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickIdol : MonoBehaviour
{
    public GameObject player;
    public GameObject pick;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        Debug.Log(pick.transform.name);
        if (pick.transform.name.Contains("Mask"))
        {
            Debug.Log("Picking");
            pick = PedestalManager.mask_inst;
            Destroy(pick);
        }
        else
        {
            pick.transform.GetComponent<Rigidbody>().isKinematic = true;
            pick.transform.GetComponent<Rigidbody>().useGravity = false;
            pick.transform.parent = player.transform.Find("FirstPersonCharacter").transform.Find("EmptyObj").transform;
        }
       
       
    }
    void OnMouseUp()
    {
        pick.transform.parent = null;
        pick.transform.GetComponent<Rigidbody>().isKinematic = false;
        pick.transform.GetComponent<Rigidbody>().useGravity = true;

    }
}

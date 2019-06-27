using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedestal : MonoBehaviour
{
    
    public GameObject trig;
    public string match;
    public bool is_placed=false;
    public GameObject particle;

    public Pedestal(GameObject empty, string idol_name)
    {
        trig = empty;
        match = idol_name;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Entered " + trig.name + "'s Trigger");
        if (collider.gameObject.name == match)
        {
            Debug.Log("Matched idol to Pedestal");
            is_placed = true;
            particle.GetComponent<ParticleSystem>().Play();
        }


    }
   public bool on_pedestal()
    {
        return is_placed;
    }
}

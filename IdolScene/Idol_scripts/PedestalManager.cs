using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using "Pedestal.cs";

public class PedestalManager : MonoBehaviour
{
    public Pedestal pedestal1;
    public Pedestal pedestal2;
    public Pedestal pedestal3;
    public GameObject mask;
    public Pedestal [] manager= new Pedestal[3];
    int mask_count = 0;
    bool have_mask = false;
    public static GameObject mask_inst;
    
    // Start is called before the first frame update
    void Start()
    {
        manager[0] = pedestal1;
        manager[1] = pedestal2;
        manager[2] = pedestal3;
        
    }
    static bool all_true(Pedestal[] myList)
    {
        bool all = true;
        for (int i=0;i<myList.Length;i++)
        {
            if (myList[i].on_pedestal() == false)
            {
                all = false;
                return all;
            }
        }
        return all;
    }
    void GenerateMaskPiece()
    {
        
         mask_inst=Instantiate(mask);
        mask_inst.transform.position = new Vector3(5.9f, 1.2f, -17.9f);
        mask_count++;
    }

    // Update is called once per frame
    void Update()
    {
        if ((all_true(manager) == true)&&(mask_count<1))
        {
            GenerateMaskPiece();
        }
    }
  

  
}

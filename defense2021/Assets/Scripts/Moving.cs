using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    private bool isOkay = true;
    public GameObject TestingOb;
    public float entitytime, pos_x, pos_y, pos_z;
    void Update()
    {
        if(isOkay)
        {
            transform.Translate(new Vector3(pos_x, pos_y, pos_z) * entitytime);
        }
        
    }
    void OnCollisionEnter(Collision collision)
    {
        isOkay = false;
    }
    void OnCollisionExit(Collision collision)
    {
        isOkay = true;
    }
    public void TestControl()
    {
        TestingOb.transform.position = new Vector3(0, 0, 0);
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectSpawn : MonoBehaviour
{
    public bool enableSpawn = false;
    public int round = 1;
    public float row = 0.5f;
    public Text roundsinfo;
    public GameObject Enemy;
    public GameObject Enemydead;
    public void SpawnEnemy()
    {
        setRoundinfo();
      
        for (int i = 0; i < 3; i++)
        {
            if (enableSpawn)
            {
                GameObject enemy = (GameObject)Instantiate(Enemy, new Vector3(row, 1.1f, 0f), Quaternion.identity);
             
                row += 50f;

            }
        }
        ++round;
        row += 50f;
    }

    void setRoundinfo() 
    {
        roundsinfo.text = "Round: " + round.ToString();
    
    
    }
    void killUnit() 
    {
        Destroy(Enemydead,10f);
    
    }
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, 3);
        killUnit();
    }
    void Update()
    {

    }
}

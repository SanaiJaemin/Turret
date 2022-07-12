using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShot : MonoBehaviour
{
    public GameObject BulletPrefab;
    
    public Transform Player;
    private float TotalTime;
    public bool IsTurret = false; 
    // Start is called before the first frame update
    
    void BulletShot()
    {
        TotalTime += Time.deltaTime;
        if (TotalTime > 0.5f)
        {
            TotalTime = 0f;
            GameObject bullet = Instantiate(BulletPrefab, transform.position,transform.rotation);
            bullet.transform.LookAt(Player);

        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            IsTurret = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            IsTurret = false;
            
        }
    }


    // Update is called once per frame
    void Update()
    {
        if(IsTurret)
        {
            transform.LookAt(Player);
            BulletShot();
        }
        else
        {
            transform.Rotate(0f, 1f, 0f);
            
        }

    }


}


            
        //}
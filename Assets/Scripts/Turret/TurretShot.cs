using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretShot : MonoBehaviour
{
    public GameObject BulletPrefab;
    
    public Transform Target;
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
            bullet.transform.LookAt(Target);

        }

    }

    private void OnTriggerStay(Collider other)
    {
        
        if (other.tag == "Player") // Player 발견시 타켓 지정
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
        Vector3 distanceVector = Target.position - transform.position;
       float Range = Vector3.Dot(transform.forward, distanceVector.normalized); //사이값

        Vector3 Cross = Vector3.Cross(transform.forward, distanceVector.normalized);
       
        if(Cross.y < 0f && Range > 0f)
        {
            
            if (IsTurret)
            {
                transform.LookAt(Target);
                BulletShot();
            }

        }
       

    }


}


            
        //}
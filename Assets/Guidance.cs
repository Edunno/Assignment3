using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guidance : MonoBehaviour
{
    [SerializeField] private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Endpoint");
    }

    // Update is called once per frame
    void Update()
    {
        bool flag = true;
        Collider[] cols = Physics.OverlapSphere(transform.position, 0.5f);
        for(int i = 0; i < cols.Length; i++){
            if(cols[i].tag == "Player"){
                flag = false;
            }
        }
        if (flag)
        {
            transform.LookAt(target.transform);
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, GetComponent<ChickenStats>().speed);
        }
    }
}

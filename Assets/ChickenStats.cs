using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenStats : MonoBehaviour
{
    public int health = 200;
    public float speed = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0){
            this.transform.Rotate(new Vector3 (0,0,1),1);
            Destroy(this.gameObject,2);
        }
    }
    public void Damage(int hurt){
        health -= hurt;
    }
}

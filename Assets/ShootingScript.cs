using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    public int damage = 20;
    public float attackSpeed = 0.5f;
    private bool ready = true;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Cooldown());
    }

    // Update is called once per frame
    void Update()
    {
        Collider[] enemyList = Physics.OverlapSphere(this.transform.position,7);
        if(ready){
            for(int i = 0; i < enemyList.Length;i++){
                if(enemyList[i].tag == "Enemy"){
                    GameObject  firstEnemy = enemyList[i].gameObject;
                    print(firstEnemy.name);
                    firstEnemy.GetComponent<ChickenStats>().Damage(damage);
                    ready = false;
                    i = enemyList.Length;
                }
            }
        }
        
    }
    IEnumerator Cooldown(){
        while(true){
            yield return new WaitForSeconds(attackSpeed);
            ready = true;
        }
    }
}

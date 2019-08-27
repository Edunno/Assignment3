using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placementScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Color col = this.transform.GetChild(0).GetComponent<MeshRenderer>().material.color;
        col.r = 0.2f;
        for(int x = 0; x<6;x++){
            this.transform.GetChild(x).GetComponent<MeshRenderer>().material.color = col;
        }
        print("Works");
    }

    // Update is called once per frame
    void Update()
    {
        Plane ground = new Plane(Vector3.up,Vector3.zero);
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float distToG = -1f;
        ground.Raycast(ray,out distToG);
        this.transform.position = ray.GetPoint(distToG);
        if(Input.GetKeyDown(KeyCode.Q)){
            Destroy(this.gameObject);
        }
    }
}

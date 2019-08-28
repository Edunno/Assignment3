using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MakeGrid : MonoBehaviour
{
    private float x;
    private float z;
    private int gridCount = 20;
    // Start is called before the first frame update
    void Start()
    {
        x = this.GetComponent<Renderer>().bounds.size.x;
        z = this.GetComponent<Renderer>().bounds.size.z;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public Vector3 ToPlaneGrid(Vector3 oV){
        for(int i = 0; i<gridCount;i++){
            if(0.5*x/gridCount <= Math.Abs(oV.x%(i*x/gridCount))){
                oV.x = i*x/gridCount;
                i = gridCount;
            }
        }
        for(int i = 0; i<gridCount;i++){
            if(0.5*z/gridCount <= Math.Abs(oV.z%(i*z/gridCount))){
                oV.z = i*z/gridCount;
                i = gridCount;
            }
        }
        return oV;
    }
}

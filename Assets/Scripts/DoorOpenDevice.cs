using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class DoorOpenDevice : MonoBehaviour
{
    [SerializeField] private Vector3 dPos; //¬ Смещение, применяемое при открывании двери.
    private bool _open; //¬ Переменная типа Boolean для слежения за открытым состоянием двери.
    private Vector3 tPos;
    private Vector3 sPos;
    private float t;

    public void Operate()
    { 
        _open = !_open;
    } 
 
    public void Activate()
    { 
        _open = true;
    } 
 
    public void Deactivate()
    { 
        _open = false;
    } 

    void Start() {
        sPos = transform.position;
        tPos = sPos + dPos;
        t = 0f;
    }
    
    void Update() 
    {
        if(_open) {
             t+=2.0f * Time.deltaTime;
        }
        else {
             t-=2.0f * Time.deltaTime;
        }
        if( t > 1) t = 1;
        if( t < 0) t = 0;
        transform.position  =  Vector3.Lerp(  sPos, tPos, t);
    }  
    

}
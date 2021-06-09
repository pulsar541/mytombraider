using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeviceOperator : MonoBehaviour
{
    public float radius = 1.5f;// ¬ Расстояние, с которого персонаж может активировать устройства.
    void Update()
    {
        if (Input.GetButtonDown("Fire3"))
        { //¬ Реакция на кнопку ввода, заданную в настройках ввода в Unity.
 
            Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius); //¬
            foreach (Collider hitCollider in hitColliders)
            {   Vector3 direction = hitCollider.transform.position - transform.position;
                if(Vector3.Dot(transform.forward, direction) > .5f) { 
                    hitCollider.SendMessage("Operate", SendMessageOptions.DontRequireReceiver); //¬
                }
            }
        }
    }
}

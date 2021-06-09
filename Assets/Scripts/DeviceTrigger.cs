using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeviceTrigger : MonoBehaviour
{
    [SerializeField] private GameObject[] targets; //¬ Список целевых объектов, которые будет активировать данный триггер.8.2. Взаимодействие с объектами путем столкновений 197
    public bool requireKey;
    void OnTriggerEnter(Collider other)
    {
        if(requireKey && Managers.Inventory.equippedItem != "key") {
            return;
        }

        foreach (GameObject target in targets)
        {
            target.SendMessage("Activate");
        }
    }
    void OnTriggerExit(Collider other)
    {
        foreach (GameObject target in targets)
        {
            target.SendMessage("Deactivate");
        }
    }
}

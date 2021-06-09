using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private string itemName; //¬ Введите имя этого элемента на панели Inspector.
    void OnTriggerEnter(Collider other)
    {
        Managers.Inventory.AddItem(itemName);
        //Debug.Log("Item collected: " + itemName);
        Destroy(this.gameObject);
    }
}

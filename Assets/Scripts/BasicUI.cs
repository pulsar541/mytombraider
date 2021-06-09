using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicUI : MonoBehaviour
{
    void OnGUI()
    {
        int posX = 10;
        int posY = 10;
        int width = 100;
        int height = 30;
        int buffer = 10;
        List<string> itemList = Managers.Inventory.GetItemList();
        if (itemList.Count == 0)
        {
            GUI.Box(new Rect(posX, posY, width, height), "No Items");
        }
        foreach (string item in itemList)
        {
            int count = Managers.Inventory.GetItemCount(item);
            Texture2D image = Resources.Load<Texture2D>("Icons/" + item);
            GUI.Box(new Rect(posX, posY, width, height), new GUIContent("(" + count + ")", image));
            posX += width + buffer;
        }

        string equipped = Managers.Inventory.equippedItem;
        if (equipped != null)
        { //¬ Отображение подготовленного элемента.
            posX = Screen.width - (width + buffer);
            Texture2D image = Resources.Load("Icons/" + equipped) as Texture2D;
            GUI.Box(new Rect(posX, posY, width, height), new GUIContent("Equipped", image));
        }
        posX = 10;
        posY += height + buffer;
        foreach (string item in itemList)
        { //¬ Просмотр всех элементов в цикле для создания кнопок.
            if (GUI.Button(new Rect(posX, posY, width, height), "Equip " + item))
            { //¬ Запуск вложенного кода при щелчке на кнопке.
                Managers.Inventory.EquipItem(item);
            }

            if (item == "health")
            { //¬ Начало нового кода.
                if (GUI.Button(new Rect(posX, posY + height + buffer, width, height), "Use Health"))
                { //¬ Запуск вложенного кода при щелчке на кнопке.
                    Managers.Inventory.ConsumeItem("health");
                    Managers.Player.ChangeHealth(25);
                }
            }
            posX += width + buffer;
        }
    }

}
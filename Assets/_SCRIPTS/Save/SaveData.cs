using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    /*
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.S))
        {
            SaveToJson();
        }
        if (Input.GetKeyUp(KeyCode.L))
        {
            LoadFromJson();
        }
    }
    public void SaveToJson()
    {
        string inventoryData = JsonUtility.ToJson(Inventory);
        string filePath = Application.persistentDataPath + "/inventoryData.json";
        Debug.Log(filePath);
        System.IO.File.WriteAllText(filePath, inventoryData);
        Debug.Log("Save data");
    }
    public void LoadFromJson()
    {
        string filePath = Application.persistentDataPath + "/inventoryData.json";
        string inventoryData = System.IO.File.ReadAllText(filePath);

        Inventory = JsonUtility.FromJson<Inventory>(inventoryData);
        Debug.Log("Chargement effectué");

    }*/
}






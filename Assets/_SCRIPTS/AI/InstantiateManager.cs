using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateManager : MonoBehaviour
{

    [SerializeField]
    private GameObject prefab1ToUse;

    [SerializeField]
    private GameObject prefab2ToUse;

    [SerializeField]
    private GameObject prefab3ToUse;

    [SerializeField]
    private Transform SPoint;

    [SerializeField]
    private Transform parentRootTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {
            //GameObject bot = Instantiate(prefab1ToUse,this.transform.position, Quaternion.identity);
            //GameObject bot = Instantiate(prefab1ToUse, SPoint.position, Quaternion.identity);
            GameObject bot = Instantiate(prefab1ToUse, SPoint.position, prefab1ToUse.transform.rotation);
            GameObject bot2 = Instantiate(prefab2ToUse, SPoint.position, prefab1ToUse.transform.rotation);
            GameObject bot3 = Instantiate(prefab2ToUse, SPoint.position, prefab1ToUse.transform.rotation);
            bot.transform.SetParent(parentRootTransform);
        }
    }
}

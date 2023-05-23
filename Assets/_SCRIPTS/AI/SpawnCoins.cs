using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    [SerializeField]
    float[] percentages;

    [SerializeField] GameObject[] objectsToSpawn;

    private GameObject obj;

    [SerializeField] private Transform[] spawnPoint;

    private void Start()
    {
        for (int i = 0; i < spawnPoint.Length; i++)
        {
            obj = objectsToSpawn[GetRandomSpawn()];
            Instantiate(obj, spawnPoint[i].transform.position, Quaternion.identity);
        }

    }
    //https://www.youtube.com/watch?v=XyNb41Zpeuo
    private int GetRandomSpawn()
    {
        float random = Random.Range(0f, 1f);
        float numForAdding = 0f;
        float total = 0;
        for (int i = 0; i < percentages.Length; i++)
        {
            total += percentages[i];
        }
            for (int i = 0; i < objectsToSpawn.Length; i++)
        {
            if (percentages[i] / total + numForAdding >= random)
            {
                return i;
            }
            else
            {
                numForAdding += percentages[i] / total;
            }
        }
        return 0;
    }
}

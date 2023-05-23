using UnityEngine;
public class LightManager : MonoBehaviour
{
    [SerializeField] private Light directionalLight;
    [SerializeField] private Light pointLight, pointLight2, pointLight3, pointLight4, pointLight5, spotLight;
    void Start()
    {
        directionalLight.GetComponent<Light>().enabled = true;
        pointLight.GetComponent<Light>().enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            directionalLight.GetComponent<Light>().enabled = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pointLight.GetComponent<Light>().enabled = true;
            pointLight2.GetComponent<Light>().enabled = true;
            pointLight3.GetComponent<Light>().enabled = true;
            pointLight4.GetComponent<Light>().enabled = true;
            pointLight5.GetComponent<Light>().enabled = true;
            spotLight.GetComponent<Light>().enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            directionalLight.GetComponent<Light>().enabled = true;
        } 
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CollectibleScript : MonoBehaviour {

	public enum CollectibleTypes {Life, Time, Type2, Type3, Type4, Type5}; // you can replace this with your own labels for the types of collectibles in your game!

	public CollectibleTypes CollectibleType; // this gameObject's type

	public bool rotate; // do you want it to rotate?

	public float rotationSpeed;

	public AudioClip collectSound;

	public GameObject collectEffect;




    [SerializeField] private int amount;
	// Use this for initialization
	void Start()
	{

    }

	// Update is called once per frame
	void Update () {

		if (rotate)
			transform.Rotate (Vector3.up * rotationSpeed * Time.deltaTime, Space.World);

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player")) 
		{
			Collect ();
		}
	}

	public void Collect()
	{
		if (collectSound)
			AudioSource.PlayClipAtPoint(collectSound, transform.position);
		if (collectEffect)
			Instantiate(collectEffect, transform.position, Quaternion.identity);

		if (CollectibleType == CollectibleTypes.Life)
		{

		}
		if (CollectibleType == CollectibleTypes.Time)
		{


			Debug.Log("More Time");

		}
		if (CollectibleType == CollectibleTypes.Type2)
		{

			//Add in code here;

			Debug.Log("Do NoType Command");
		}
		if (CollectibleType == CollectibleTypes.Type3)
		{

			//Add in code here;

			Debug.Log("Do NoType Command");
		}
		if (CollectibleType == CollectibleTypes.Type4)
		{

			//Add in code here;

			Debug.Log("Do NoType Command");
		}
		if (CollectibleType == CollectibleTypes.Type5)
		{

			//Add in code here;

			Debug.Log("Do NoType Command");
		}

		Destroy(gameObject);
	}
}

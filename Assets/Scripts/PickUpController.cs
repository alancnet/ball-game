using UnityEngine;
using System.Collections;

public class PickUpController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(15 * Time.deltaTime, 45 * Time.deltaTime, 35 * Time.deltaTime);
	}

    // When collided by player
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            other.SendMessage("OnPickUpTrigger");
        }
    }
}

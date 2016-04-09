using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public Text scoreText;
    public float speed;
    private Rigidbody rb;
    private int pickUps;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        UpdateScore();
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        rb.AddForce(x * speed, 0, z * speed);
        
    }

    void OnPickUpTrigger()
    {
        pickUps++;
        UpdateScore();
    }

    void UpdateScore()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + pickUps;
        }
    }
    
}

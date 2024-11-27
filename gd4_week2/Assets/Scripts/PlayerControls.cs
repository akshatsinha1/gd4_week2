using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float movementSpeed = 10;
    Rigidbody rb;
    float timer = 60;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        //METHOD 1

        //transform.position = transform.position + new Vector3(0, 0, movementSpeed * Time.deltaTime);
        //transform.position += new Vector3(0, 0, movementSpeed * Time.deltaTime);

        //setting up a timer
        timer -=Time.deltaTime;

        if (timer == 0) {//end game
                         }

       

        //METHOD 2
        //transform.Translate(0,0, movementSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);

        //movementSpeed += Time.deltaTime * 0.2f;

        //METHOD 3
        //rb.AddForce(Vector3.forward * movementSpeed);

    }
}

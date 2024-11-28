using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float movementSpeed = 10;
    Rigidbody rb;
    float timer = 60;
    public float turnSpeed = 45;
    //float vertical, horizontal;
    public string playerIndex;


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



        //Horizontal Input (LEFT-RIGHT Input)
        float horizontal = Input.GetAxis("Horizontal" + playerIndex);

        //Vertical Input (UP-DOWN/FORWARD-BACKWARDS Input)
        float vertical = Input.GetAxis("Vertical" + playerIndex);

        if(Input.GetButtonDown("Jump"))
        {
            //make character jump
        }
        


        //METHOD 2
        //transform.Translate(0,0, movementSpeed * Time.deltaTime);

        //transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime * vertical);
        transform.Rotate(Vector3.up * turnSpeed * horizontal * Time.deltaTime);
     
        

        //METHOD 3
        rb.AddForce(transform.forward * movementSpeed * vertical);
        ///rb.AddTorque(transform.up * turnSpeed * horizontal);




    }
}

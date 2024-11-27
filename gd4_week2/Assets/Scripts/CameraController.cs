using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 cameraOffset;
    Vector3 defaultCameraOffset;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //METHOD 3
        defaultCameraOffset = transform.position - playerTransform.position  ;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //METHOD 1
        //transform.position = playerTransform.position + new Vector3(0,7,-10);

        //METHOD 2
        //transform.position = playerTransform.position + cameraOffset;

        //METHOD 3
        transform.position = playerTransform.position + defaultCameraOffset;
    }
}

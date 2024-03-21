using System;
using UnityEngine;

public class CamerController : MonoBehaviour
{
    private bool doMovement = true; 
    
    public float panSpeed = 30f;
    public float panBorderThickness = 10f;
    public float scrollSpeed = 5f;
    public float minY = 10f;
    public float maxY = 80f; 
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            doMovement = !doMovement; 
        }
        
        if (!doMovement)
        {
            return; 
        }
        
        
        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)
        {
            float temp = panSpeed * Time.deltaTime;
            transform.Translate(Vector3.forward * temp, Space.World);
        }
        
        if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
        {
            float temp = panSpeed * Time.deltaTime;
            transform.Translate(Vector3.back* temp, Space.World);
        }
        
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
        {
            float temp = panSpeed * Time.deltaTime;
            transform.Translate(Vector3.right * temp, Space.World);
        }
        
        if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
        {
            float temp = panSpeed * Time.deltaTime;
            transform.Translate(Vector3.left * temp, Space.World);
        }


        float scroll = Input.GetAxis("Mouse ScrollWheel");

        Vector3 pos = transform.position;

        pos.y -= scroll* 1000 * scrollSpeed * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        
        transform.position = pos; 
    }
}

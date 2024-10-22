using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class DuckoControler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");


        Vector2 position = transform.position;
        position.x = position.x + 9.0f * horizontal * Time.deltaTime;
        position.y = position.y + 9.0f * vertical * Time.deltaTime;

        transform.position = position;
    }
}
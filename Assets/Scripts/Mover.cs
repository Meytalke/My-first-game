using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed= 10f;
    
    // Start is called before the first frame update
    void Start()
    {
         printInstuctions();
        //transform.Translate(0.01f,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();  
    }

    void printInstuctions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls!");

    }

    void MovePlayer()
    {
        float zValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed * -1;
        float xValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
    }
}

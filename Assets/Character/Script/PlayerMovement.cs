using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float moveVertical = 0f;
        float moveHorizontal = 0f;

        // Check for vertical movement
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            moveVertical = 1f;
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            moveVertical = -1f;
        }

        // Check for horizontal movement
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            moveHorizontal = -1f;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            moveHorizontal = 1f;
        }

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);
        transform.Translate(movement * speed * Time.deltaTime);
    }

}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacman2Movement : MonoBehaviour
{

    [SerializeField]
    private Movement movement;

    // Update is called once per frame
    private void Update()
    {
        // Set the new direction based on the current input
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            movement.SetDirection(Vector2.up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            movement.SetDirection(Vector2.down);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            movement.SetDirection(Vector2.left);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow)) {
            movement.SetDirection(Vector2.right);
        }

        // Rotate pacman to face the movement direction
        float angle = Mathf.Atan2(movement.direction.y, movement.direction.x);
        transform.rotation = Quaternion.AngleAxis(angle * Mathf.Rad2Deg, Vector3.forward);
    }
}

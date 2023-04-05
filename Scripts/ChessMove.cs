using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessMove : MonoBehaviour
{
    private Vector3 offset;    // The offset between the mouse position and the chess piece position
    private float distance;      // The distance between the camera and the chess piece

    private void OnMouseDown()
    {
        // Calculate the distance between the camera and the chess piece
        distance = Camera.main.WorldToScreenPoint(transform.position).z;
        // Calculate the offset between the mouse position and the chess piece position
        offset = transform.position - GetMouseWorldPos();
    }

    private void OnMouseDrag()
    {
        // Calculate the new position of the chess piece based on the mouse position and offset
        Vector3 newPos = GetMouseWorldPos() + offset;
        // Set the Y position of the chess piece to be the same as its current Y position, so it cannot move up or down
        newPos.y = transform.position.y;
        // Set the position of the chess piece to the new position
        transform.position = newPos;
    }

    private Vector3 GetMouseWorldPos()
    {
        // Get the position of the mouse on the screen
        Vector3 mousePoint = Input.mousePosition;
        // Set the Z coordinate of the mouse position to be the distance between the camera and the chess piece
        mousePoint.z = distance;

        // Convert the mouse position to a world position using the camera
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
}

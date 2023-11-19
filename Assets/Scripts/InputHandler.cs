

//This script will have a method “HandleInput” to process commands.

using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public float moveUnit = 1.0f;
    public static bool InputEnabled = true;
    // Update is called once per frame
    void Update()
    {
        if(InputEnabled)
        {
            HandleInput();
        }
    }

    // Process commands
    void HandleInput()
    {
        Command cmd = null;

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            cmd = new Move(new Vector2(-moveUnit, 0));
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            cmd = new Move(new Vector2(moveUnit, 0));
        }
        else if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            cmd = new Move(new Vector2(0, moveUnit));
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            cmd = new Move(new Vector2(0, -moveUnit));
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Close the application
            Application.Quit();
            return;  // Return immediately to skip the rest of the code
        }

        if (cmd != null)
        {
            cmd.Execute(gameObject);
        }
        
    }
    
}
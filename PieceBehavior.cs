using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceBehavior : MonoBehaviour
{
    public GameController gc;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        // Allows for selection

        if (Input.GetKey(KeyCode.LeftShift)) // For gluing
        {
            if (!gc.selectObj1)
            {
                RaycastHit hitInfo;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hitInfo))
                {
                    gc.select1(hitInfo.point, hitInfo.collider.gameObject);
                }
            }
            else if (!gc.selectObj2 && gc.selectObj1 != gameObject)
            {
                RaycastHit hitInfo;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hitInfo))
                {
                    gc.select2(hitInfo.point, hitInfo.collider.gameObject);
                    gc.snap();
                }
            }
        }
        else // For movement
        {
            gc.SetSelection(gameObject);
        }

    }

    public void SetGameController(GameController con)
    {
        gc = con;
    }
}

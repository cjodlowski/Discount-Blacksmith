using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject CurrentSelection;
    public float Speed = 0.1f;
    public float RotateSpeed = 100f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && CurrentSelection)
        {
            float hoz = Input.GetAxis("Mouse X");
            float ver = Input.GetAxis("Mouse Y");
            Debug.Log(hoz);
            Debug.Log(ver);
            CurrentSelection.transform.position += (new Vector3(hoz * Speed, ver * Speed, 0));
        }

        if(Input.GetKey(KeyCode.A) && CurrentSelection) {
            CurrentSelection.transform.Rotate(Vector3.up * RotateSpeed, Space.World);
        }

        if (Input.GetKey(KeyCode.S) && CurrentSelection)
        {
            CurrentSelection.transform.Rotate(Vector3.left * RotateSpeed, Space.World);
        }
        if (Input.GetKey(KeyCode.D) && CurrentSelection)
        {
            CurrentSelection.transform.Rotate(Vector3.down * RotateSpeed, Space.World);
        }
        if (Input.GetKey(KeyCode.W) && CurrentSelection)
        {
            CurrentSelection.transform.Rotate(Vector3.right * RotateSpeed, Space.World);

        }
    }

    public void SetSelection(GameObject go)
    {
        CurrentSelection = go;
    }


}

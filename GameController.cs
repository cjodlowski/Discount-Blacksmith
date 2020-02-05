using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // For glue
    public int breakForce = 1000;
    public GameObject point1;
    public GameObject point2;
    public GameObject selectObj1;
    public GameObject selectObj2;

    // For move
    public GameObject CurrentSelection;
    public float Speed = 0.5f;
    public float RotateSpeed = 100f;

    void Start()
    {
        
    }

    void Update()
    {
        // Allows movement

        if (Input.GetButton("Fire1") && CurrentSelection)
        {
            Debug.Log("Move");
            float hoz = Input.GetAxis("Mouse X");
            float ver = Input.GetAxis("Mouse Y");
            CurrentSelection.transform.position += (new Vector3(hoz * Speed, ver * Speed, 0));
        }

        if (Input.GetKey(KeyCode.A) && CurrentSelection)
        {
            Debug.Log("A");
            CurrentSelection.transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime, Space.World);
        }

        if (Input.GetKey(KeyCode.S) && CurrentSelection)
        {
            Debug.Log("S");
            CurrentSelection.transform.Rotate(Vector3.left * RotateSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.D) && CurrentSelection)
        {
            Debug.Log("D");
            CurrentSelection.transform.Rotate(Vector3.down * RotateSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.W) && CurrentSelection)
        {
            Debug.Log("W");
            CurrentSelection.transform.Rotate(Vector3.right * RotateSpeed * Time.deltaTime, Space.World);
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll > 0 && CurrentSelection)
        {
            Debug.Log("Backward");
            CurrentSelection.transform.position += Vector3.back * scroll * 100 * Time.deltaTime;
        }
        if (scroll < 0 && CurrentSelection)
        {
            Debug.Log("Forward");
            CurrentSelection.transform.position += Vector3.back * scroll * 100 * Time.deltaTime;
        }
    }

    // Selects the first object for gluing
    public void select1(Vector3 point, GameObject go)
    {
        selectObj1 = go;
        point1.transform.position = point;
        point1.SetActive(true);
        FixedJoint fj = point1.AddComponent(typeof(FixedJoint)) as FixedJoint;
        fj.connectedBody = selectObj1.gameObject.GetComponent<Rigidbody>();
    }

    // Selects the second object for gluing
    public void select2(Vector3 point, GameObject go)
    {
        selectObj2 = go;
        point2.transform.position = point;
        point2.SetActive(true);
        FixedJoint fj = point2.AddComponent(typeof(FixedJoint)) as FixedJoint;
        fj.connectedBody = selectObj2.gameObject.GetComponent<Rigidbody>();
    }

    // Snaps two selected objects together
    public void snap()
    {
        if (selectObj1 != null && selectObj2 != null)
        {
            Debug.Log("GC Snap");
            SnapBehavior sb = point2.AddComponent<SnapBehavior>() as SnapBehavior;
        }
    }
    
    // Glues two selected objects together
    public void glue()
    {
        if (selectObj1 != null && selectObj2 != null)
        {
            //selectObj1.GetComponent<Rigidbody>().velocity = Vector3.zero;
            //selectObj2.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Debug.Log("Gluing!");
            //SpringJoint sj = selectObj1.AddComponent(typeof(SpringJoint)) as SpringJoint;
            FixedJoint sj = selectObj1.AddComponent(typeof(FixedJoint)) as FixedJoint;
            sj.enableCollision = true;
            sj.autoConfigureConnectedAnchor = false;
            sj.connectedBody = selectObj2.GetComponent<Rigidbody>();
            sj.anchor = (point1.transform.position - selectObj1.transform.position);
            sj.connectedAnchor = (point2.transform.position - selectObj2.transform.position);
            //sj.spring = 100000;
            //sj.damper = 10000;
            //sj.maxDistance = 0.1f;
            sj.breakForce = breakForce;
            Destroy(point1.GetComponent<FixedJoint>());
            Destroy(point2.GetComponent<FixedJoint>());
            point1.SetActive(false);
            point2.SetActive(false);
            selectObj1 = null;
            selectObj2 = null;
        }
    }

    // Set selection for moving objects
    public void SetSelection(GameObject go)
    {
        CurrentSelection = go;
    }

    public void finish()
    {
        if (CurrentSelection)
        {
            CurrentSelection.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * 10000);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapBehavior : MonoBehaviour
{
    public GameObject target;
    public GameObject gc;
    
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Point1");
        gc = GameObject.FindGameObjectWithTag("GameController");
    }

    void Update()
    {
        if (target)
        {
            if (Vector3.Distance(transform.position, target.transform.position) > 0.5f)
            {
                Debug.Log("Snapping...");
                transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 2 * Time.deltaTime);
            }
            else
            {
                gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
                Debug.Log("Snapped!");
                Destroy(this);
            }
        }
    }

    private void OnDestroy()
    {
        gc.GetComponent<GameController>().glue();
    }
}

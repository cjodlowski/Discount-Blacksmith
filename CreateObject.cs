using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public GameObject bowFrame;
    public GameObject chainLink;
    public GameObject daggerWhole;
    public GameObject halberdHead;
    public GameObject longStick;
    public GameObject nunchukStick;
    public GameObject scytheBlade;
    public GameObject spearHead;
    public GameObject spikedBall;
    public GameObject swordBlade;
    public GameObject swordHandle;
    public GameObject trideantHead;
    public float PosX;
    public float PosY;
    public float PosZ;
    public float RotX;
    public float RotY;
    public float RotZ;
    public float x;
    public float y;
    public float z;


    // Spawn Buttons

    //TODO: customize quaternion stuff

    public void SpawnBowFrame()
    {
        GameObject o = Instantiate(bowFrame, new Vector3(PosX, PosY, PosZ), Quaternion.Euler(new Vector3(90, 180, 0)));
        GameController gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        Debug.Log(gc);
        o.GetComponent<PieceBehavior>().SetGameController(gc);
    }

    //TODO: multiple links
    public void SpawnChain()
    {
        GameObject o = Instantiate(chainLink, new Vector3(PosX, PosY, PosZ), Quaternion.Euler(new Vector3(0, 0, 0)));
        GameController gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        Debug.Log(gc);
        o.GetComponent<PieceBehavior>().SetGameController(gc);
    }

    public void SpawnDaggerWhole()
    {
        GameObject o = Instantiate(daggerWhole, new Vector3(PosX, PosY, PosZ), Quaternion.Euler(new Vector3(0, 90, 0)));
        GameController gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        Debug.Log(gc);
        o.GetComponent<PieceBehavior>().SetGameController(gc);
    }

    public void SpawnHalberdHead()
    {
        GameObject o = Instantiate(halberdHead, new Vector3(PosX, PosY, PosZ), Quaternion.Euler(new Vector3(0, 180, 0)));
        GameController gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        Debug.Log(gc);
        o.GetComponent<PieceBehavior>().SetGameController(gc);
    }

    public void SpawnLongStick()
    {
        GameObject o = Instantiate(longStick, new Vector3(PosX, PosY, PosZ), Quaternion.Euler(new Vector3(0, 90, 0)));
        GameController gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        Debug.Log(gc);
        o.GetComponent<PieceBehavior>().SetGameController(gc);
    }

    public void SpawnNunchukStick()
    {
        GameObject o = Instantiate(nunchukStick, new Vector3(PosX, PosY, PosZ), Quaternion.Euler(new Vector3(0, 90, 0)));
        GameController gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        Debug.Log(gc);
        o.GetComponent<PieceBehavior>().SetGameController(gc);
    }

    public void SpawnScytheBlade()
    {
        GameObject o = Instantiate(scytheBlade, new Vector3(PosX, PosY, PosZ), Quaternion.Euler(new Vector3(0, 0, 0)));
        GameController gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        Debug.Log(gc);
        o.GetComponent<PieceBehavior>().SetGameController(gc);
    }

    public void SpawnSpearHead()
    {
        GameObject o = Instantiate(spearHead, new Vector3(PosX, PosY, PosZ), Quaternion.Euler(new Vector3(0, 90, 90)));
        GameController gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        Debug.Log(gc);
        o.GetComponent<PieceBehavior>().SetGameController(gc);
    }

    public void SpawnSpikedBall()
    {
        GameObject o = Instantiate(spikedBall, new Vector3(PosX, PosY, PosZ), Quaternion.Euler(new Vector3(RotX, RotY, RotZ)));
        GameController gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        Debug.Log(gc);
        o.GetComponent<PieceBehavior>().SetGameController(gc);
    }

    public void SpawnSwordBlade()
    {
        GameObject o = Instantiate(swordBlade, new Vector3(PosX, PosY, PosZ), Quaternion.Euler(new Vector3(0, 90, 0)));
        GameController gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        Debug.Log(gc);
        o.GetComponent<PieceBehavior>().SetGameController(gc);
    }

    public void SpawnSwordHandle()
    {
        GameObject o = Instantiate(swordHandle, new Vector3(PosX, PosY, PosZ), Quaternion.Euler(new Vector3(90, 180, 0)));
        GameController gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        Debug.Log(gc);
        o.GetComponent<PieceBehavior>().SetGameController(gc);
    }

    public void SpawnTrideantHead()
    {
        GameObject o = Instantiate(trideantHead, new Vector3(PosX, PosY, PosZ), Quaternion.Euler(new Vector3(-90, 0, 0)));
        GameController gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        Debug.Log(gc);
        o.GetComponent<PieceBehavior>().SetGameController(gc);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class platformBehaviour : MonoBehaviour
{

    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Player)
        {
            Debug.Log("Colliding");
            Player.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.parent = null;
        }
    }


}
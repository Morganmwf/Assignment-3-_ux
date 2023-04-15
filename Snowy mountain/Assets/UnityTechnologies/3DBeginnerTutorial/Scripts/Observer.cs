using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Player;
    public GameEnding gameEnding;
    bool IsInRange = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player.gameObject)
        {
            IsInRange = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player.gameObject)
        {
            IsInRange = false;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (IsInRange == true)
        {
            Vector3 dir = Player.position - transform.position + Vector3.up;
            Ray ray = new Ray(transform.position,dir);
            RaycastHit raycastHit;
            if (Physics.Raycast(ray, out raycastHit))
            {
                if (raycastHit.collider.transform == Player)
                {
                    gameEnding.Caught();
                }
            }
        }
    }
}

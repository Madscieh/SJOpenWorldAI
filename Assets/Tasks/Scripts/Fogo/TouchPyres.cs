using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPyres : MonoBehaviour
{
    [SerializeField] GameObject fire;
    public static int numPyres = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(fire, new Vector3 (transform.position.x + 35f, 7.5f, transform.position.z + 12.47f), Quaternion.identity);
            numPyres++;
        }
    }
}

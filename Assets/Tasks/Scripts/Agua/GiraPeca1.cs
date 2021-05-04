using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiraPeca1 : MonoBehaviour
{
    [SerializeField] Transform peca;
    float intervaloTempo = 0f;
    readonly float atrasoTempo = .5f;
    int numRotacao = 0;

    private void OnTriggerEnter(Collider other)
    {
        intervaloTempo += Time.deltaTime;
        if (other.CompareTag("Player") && numRotacao < 2)
        {
            peca.RotateAround(peca.position, Vector3.up, 90);
            numRotacao++;
        }
        if (numRotacao == 2 && intervaloTempo > atrasoTempo)
        {
            intervaloTempo = 0;
            GiraPeca.numPecas++;
        }
    }
}
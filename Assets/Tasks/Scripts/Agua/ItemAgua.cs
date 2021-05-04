using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAgua : MonoBehaviour
{
    [SerializeField] GameObject item;
    private void Update()
    {
        if (GiraPeca.numPecas == 4)
        {
            Invoke(nameof(ItemAparece), .5f);
            GiraPeca.numPecas = 0;
        }
    }
    public void ItemAparece()
    {
        Instantiate(item, new Vector3(22, 4, -8.8f), Quaternion.identity);
    }
}
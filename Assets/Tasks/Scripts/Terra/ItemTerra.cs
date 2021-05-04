using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTerra : MonoBehaviour
{
    [SerializeField] GameObject item;
    private void Update()
    {
        if (MoveCubes.numCubes == 4)
        {
            Invoke(nameof(ItemAparece), .5f);
            MoveCubes.numCubes = 0;
        }
    }
    public void ItemAparece()
    {
        Instantiate(item, new Vector3(22.5f, 4.5f, -3), Quaternion.identity);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFogo : MonoBehaviour
{
    [SerializeField] GameObject item;
    [SerializeField] Transform Player;
    private void Update()
    {
        if (TouchPyres.numPyres == 5)
        {
            Invoke(nameof(ItemAparece), .5f);
            TouchPyres.numPyres = 0;
        }
    }
    public void ItemAparece()
    {
        Instantiate(item, Player.position + Player.forward + Player.up * .75f, Quaternion.identity);
    }
}

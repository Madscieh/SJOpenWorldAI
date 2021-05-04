using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TrocarCorAgua : MonoBehaviour
{
    Graphic m_Graphic;
    Color m_MyColor;

    // Start is called before the first frame update
    void Start()
    {
        m_Graphic = GetComponent<Graphic>();
        m_MyColor = Color.black;
        m_Graphic.color = m_MyColor;
    }

    // Update is called once per frame
    public void Coletado()
    {
            m_MyColor = Color.white;
            m_Graphic.color = m_MyColor;
    }
}

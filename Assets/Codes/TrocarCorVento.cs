using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TrocarCorVento : MonoBehaviour
{
    Graphic m_Graphic;
    Color m_MyColor;
    void Start()
    {
        m_Graphic = GetComponent<Graphic>();
        m_MyColor = Color.black;
        m_Graphic.color = m_MyColor;
    }
     public void Coletado()
    {
        m_MyColor = Color.white;
        m_Graphic.color = m_MyColor;
    }
}
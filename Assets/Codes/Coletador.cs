using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletador : MonoBehaviour
{
    public int PegouAgua;
    public int AguaColetada;
    public int PegouVento;
    public int VentoColetado;
    public int PegouFogo;
    public int FogoColetado;
    public int PegouTerra;
    public int TerraColetada;

    private void Start()
    {
        AguaColetada = PlayerPrefs.GetInt("PegouAgua");
        VentoColetado = PlayerPrefs.GetInt("PegouVento");
        FogoColetado = PlayerPrefs.GetInt("PegouFogo");
        TerraColetada = PlayerPrefs.GetInt("PegouTerra");
    }

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    void Update()
    {
        if (Input.GetKey("="))
        {
            FindObjectOfType<TrocarCorTerra>().Coletado();
        }
        else PlayerPrefs.GetInt("PegouAgua");
        {

            if (AguaColetada > 0)
            {
                FindObjectOfType<TrocarCorAgua>().Coletado();
                PlayerPrefs.Save();

            }

            else PlayerPrefs.GetInt("PegouVento");

            if (VentoColetado > 0)
            {
                FindObjectOfType<TrocarCorVento>().Coletado();
                PlayerPrefs.Save();
            }

            else PlayerPrefs.GetInt("PegouFogo");

            if (FogoColetado > 0)
            {
                FindObjectOfType<TrocarCorFogo>().Coletado();
                PlayerPrefs.Save();
            }

            else PlayerPrefs.GetInt("PegouTerra");
            
            if (TerraColetada > 0)
            {
                FindObjectOfType<TrocarCorTerra>().Coletado();
                PlayerPrefs.Save();
            }
                    
        }
    }

    public void Agua()
    {
        PlayerPrefs.SetInt("PegouAgua", AguaColetada);
        AguaColetada += 1;

    }
    public void Vento()
    {
        PlayerPrefs.SetInt("PegouVento", VentoColetado);
        VentoColetado += 1;
    }

    public void Fogo()
    {
        PlayerPrefs.SetInt("PegouFogo", FogoColetado);
        FogoColetado += 1;
    }
    public void Terra()
    {
        PlayerPrefs.SetInt("PegouTerra", TerraColetada);
        TerraColetada += 1;
    }
}   

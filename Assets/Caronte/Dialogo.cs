using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogo : MonoBehaviour
{
    //Responsável pelas mensagens de texto na tela

    // Start is called before the first frame update
    public Text textoNPC;
    public string texto;
    public GameObject painel;
    public GameObject paineldesativar;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        // Liga o painel e timescale=0

        if (other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            textoNPC.text = texto;
            painel.SetActive(true);
            //paineldesativar.SetActive(false);

        }

    }

    // Função para o botão na UI do diálogo
    public void ExitText()
    {
        Time.timeScale = 1;
        painel.SetActive(false);
        GetComponent<Collider>().isTrigger = false;

        //paineldesativar.SetActive(true);
        Invoke("RearmTrigger", 2);

    }
    void RearmTrigger()
    {
        GetComponent<Collider>().isTrigger = true;
    }
}

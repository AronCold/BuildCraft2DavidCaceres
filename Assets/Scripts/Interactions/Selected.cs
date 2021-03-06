using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selected : MonoBehaviour
{
    private Color color;

    private Material textura;

    public CameraController camarita;

    public Button contratos;

    public Button prestamo;
  
    public GameObject objeto;

    public GameObject ventanaEmergente;

    public NewConstruction construccion;

    // Start is called before the first frame update
    void Start()
    {
        color = objeto.GetComponent<Color>();

        textura = objeto.GetComponent<Material>();

        ventanaEmergente.SetActive(false);

        camarita.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {    

    }

    private void OnMouseDown()
    {
        Debug.Log("FUNCIONA EL DETECTOR DE SITIOS");

        ventanaEmergente.SetActive(true);

        camarita.enabled = false;

        contratos.enabled = false;

        prestamo.enabled = false;



        //Destroy(objeto);
    }

    private void OnMouseOver()
    {
        

    }

    private void OnMouseExit()
    {
        
    }

    
}

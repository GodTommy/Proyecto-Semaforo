using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void VelocidadDespacito()
    {
        Time.timeScale = 0.5f;
    }

    public void VelocidadNormal()
    {
        Time.timeScale = 1f;
    }

    public void VelocidadRapidito()
    {
        Time.timeScale = 2f;
    }
}

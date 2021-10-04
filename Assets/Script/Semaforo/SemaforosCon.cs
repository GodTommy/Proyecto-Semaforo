using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SemaforosCon : MonoBehaviour
{
    public List<GameObject> SemAb;
    public List<GameObject> SemAr;
    public List<GameObject> SemIzq;
    public List<GameObject> SemDer;
    public List<GameObject> Stops;
    public List<GameObject> Continue;
    public List<GameObject> Destructores;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SemCon(5f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SemAbArRojo ()
    {
        SemAb[0].SetActive(true);
        SemAb[1].SetActive(false);
        SemAb[2].SetActive(false);

        SemAr[0].SetActive(true);
        SemAr[1].SetActive(false);
        SemAr[2].SetActive(false);

        Stops[0].SetActive(true);
        Stops[1].SetActive(true);

        Continue[0].SetActive(false);
        Continue[1].SetActive(false);

        Destructores[0].SetActive(true);
        Destructores[1].SetActive(true);
    }

    void SemAbArAmarillo()
    {
        SemAb[0].SetActive(false);
        SemAb[1].SetActive(true);
        SemAb[2].SetActive(false);

        SemAr[0].SetActive(false);
        SemAr[1].SetActive(true);
        SemAr[2].SetActive(false);

        Stops[0].SetActive(true);
        Stops[1].SetActive(true);

        Continue[0].SetActive(false);
        Continue[1].SetActive(false);

        Destructores[0].SetActive(false);
        Destructores[1].SetActive(false);
    }

    void SemAbArVerde()
    {
        SemAb[0].SetActive(false);
        SemAb[1].SetActive(false);
        SemAb[2].SetActive(true);

        SemAr[0].SetActive(false);
        SemAr[1].SetActive(false);
        SemAr[2].SetActive(true);

        Stops[0].SetActive(false);
        Stops[1].SetActive(false);

        Continue[0].SetActive(true);
        Continue[1].SetActive(true);

        Destructores[0].SetActive(false);
        Destructores[1].SetActive(false);
    }

    void SemIzqDerRojo()
    {
        SemIzq[0].SetActive(true);
        SemIzq[1].SetActive(false);
        SemIzq[2].SetActive(false);

        SemDer[0].SetActive(true);
        SemDer[1].SetActive(false);
        SemDer[2].SetActive(false);

        Stops[2].SetActive(true);
        Stops[3].SetActive(true);

        Continue[2].SetActive(false);
        Continue[3].SetActive(false);

        Destructores[2].SetActive(true);
        Destructores[3].SetActive(true);
    }

    void SemIzqDerAmarillo()
    {
        SemIzq[0].SetActive(false);
        SemIzq[1].SetActive(true);
        SemIzq[2].SetActive(false);

        SemDer[0].SetActive(false);
        SemDer[1].SetActive(true);
        SemDer[2].SetActive(false);

        Stops[2].SetActive(true);
        Stops[3].SetActive(true);

        Continue[2].SetActive(false);
        Continue[3].SetActive(false);

        Destructores[2].SetActive(false);
        Destructores[3].SetActive(false);
    }

    void SemIzqDerVerde()
    {
        SemIzq[0].SetActive(false);
        SemIzq[1].SetActive(false);
        SemIzq[2].SetActive(true);

        SemDer[0].SetActive(false);
        SemDer[1].SetActive(false);
        SemDer[2].SetActive(true);

        Stops[2].SetActive(false);
        Stops[3].SetActive(false);

        Continue[2].SetActive(true);
        Continue[3].SetActive(true);

        Destructores[2].SetActive(false);
        Destructores[3].SetActive(false);
    }

    IEnumerator SemCon(float time)
    {
        while(true)
        {
            SemAbArRojo();
            SemIzqDerVerde();
            yield return new WaitForSeconds(3f);
            SemIzqDerAmarillo();
            yield return new WaitForSeconds(2f);
            SemIzqDerRojo();
            SemAbArVerde();
            yield return new WaitForSeconds(time);
            SemAbArAmarillo();
            yield return new WaitForSeconds(2f);
        }
    }
}

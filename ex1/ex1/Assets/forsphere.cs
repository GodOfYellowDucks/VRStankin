using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class forsphere : MonoBehaviour
{
    public GameObject capsule;
    public Text text;
    public int cntr;
    public Button btnCntr;
    // Start is called before the first frame update
    void Start()
    {
        cntr = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        text.text = "Вы нажали " + cntr.ToString() + " раз";
        if (cntr % 2 == 0) {capsule.SetActive(false); }
        if(cntr % 2 != 0) { capsule.gameObject.GetComponent<Renderer>().material.color = new Color32((byte)0, (byte)255, (byte)0, 1); capsule.SetActive(true); }
    }
    public void btnClck()
    {
        cntr = cntr + 1;
    }
}

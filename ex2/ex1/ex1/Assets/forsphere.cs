using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
public class forsphere : MonoBehaviour
{
    public GameObject capsule;
    public Text text;
    public Text textHP;
    public int cntr;
    public Button btnCntr;
    public int HPCntr;
    public float Speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        cntr = 0;
        HPCntr = 10;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * 10*Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 10*Speed * Time.deltaTime);
        }
        text.text = "Вы нажали " + cntr.ToString() + " раз.";
        textHP.text = "Здоровье: " + HPCntr.ToString();
        if (cntr % 2 == 0) { capsule.gameObject.GetComponent<Renderer>().material.color = new Color32((byte)0, (byte)255, (byte)0, 1); }//capsule.SetActive(true); ;
        if (cntr % 2 != 0) {capsule.gameObject.GetComponent<Renderer>().material.color = new Color32((byte)255, (byte)0, (byte)0, 1); }//capsule.SetActive(false) 
        }
    public void btnClck()
    {
        cntr = cntr + 1;
    }
    private void OnCollisionEnter(Collision collision)
    {
        HPCntr--;
    }
    private void OnCollisionStay(Collision collision)
    {
        
    }
    private void OnCollisionExit(Collision collisqion)
    {

    }
    private void OnTriggerEnter(Collider other)
    {

    }
    private void OnTriggerStay(Collider other)
    {

    }
    private void OnTriggerExit(Collider other)
    {

    }
}

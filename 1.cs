using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class zombie : MonoBehaviour {
    public TMP_InputField firstInput;
    public TMP_InputField SecInput;
    public TMP_Text dist;
    public TMP_Text x0;
    public TMP_Text z0;
    
     public Vector3 dir = new Vector3(0, 0, 0);
    public float x;
    public float z;
    public float speed = 0.0005f;
    private float progres;
    Transform camera = Camera.main.transform;

    void Start() {
        x0.GetComponent<TMP_Text>();
        z0.GetComponent<TMP_Text>();
        dist.GetComponent<TMP_Text>();
        firstInput.GetComponent<TMP_InputField>();
        SecInput.GetComponent<TMP_InputField>();
        x = float.Parse(firstInput.text);
        z = float.Parse(SecInput.text);
        dir = new Vector3(x, 0, z);
    }

    void Update() {
        Vector3 dir = put - transform.position;

        if (transform.position != dir) {
            transform.LookAt(new Vector3(dir.x, 0, dir.z));
            transform.position = Vector3.Lerp(transform.position, dir, progres);
            progres += speed;
        }

        else {
            x = float.Parse(firstInput.text);
            z = float.Parse(SecInput.text);
            dir = new Vector3(x, 0, z);
            progres = 0;
        }


        x0.text = ((System.Math.Round(transform.position.x)).ToString());
        z0.text = ((System.Math.Round(transform.position.z)).ToString());
        dist.text = (System.Math.Round((System.Math.Sqrt(System.Math.Pow((transform.position.x - x) , 2) + System.Math.Pow((transform.position.z - z), 2))))).ToString();
    }
}

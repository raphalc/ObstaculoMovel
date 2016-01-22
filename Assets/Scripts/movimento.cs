using UnityEngine;
using System.Collections;

public class movimento : MonoBehaviour {

    // Use this for initialization
    bool praCima;
	void Start () {
        praCima = true;
	}
	
	// Update is called once per frame
	void Update () {
        print(transform.localPosition);
        if (transform.localPosition.y <= 3.0f && praCima)
            transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        else if (transform.localPosition.y > 3.0f)
        {
            praCima = false;
            print("topo");
            print(transform.localPosition.y);
        }
        else if (!praCima)
        {
            if (transform.localPosition.y <= 0.0f)
                praCima = true;
            else
                transform.Translate(Vector3.down * Time.deltaTime, Space.World);
        }
   }
}

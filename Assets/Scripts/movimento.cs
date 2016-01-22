using UnityEngine;
using System.Collections;

public class movimento : MonoBehaviour
{

    public class ObstaculoMovel
    {
        private bool praCima;
        public GameObject obst;


        public ObstaculoMovel(bool pc)
        {
            this.praCima = pc;
        }
        public void movimentoVertical()
        {
            print(obst.transform.localPosition);
            print("antes");
            if (obst.transform.localPosition.y <= 3.0f && this.praCima)
                obst.transform.Translate(Vector3.up * Time.deltaTime, Space.World);

            if (obst.transform.localPosition.y >= 3.0f)
            {
                this.praCima = false;
                print("topo");
                print(obst.transform.localPosition.y);
            }

            if (!this.praCima)
            {
                print("Pra baixo");
                if (obst.transform.localPosition.y <= 0.5f)
                    this.praCima = true;
                else
                    obst.transform.Translate(Vector3.down * Time.deltaTime, Space.World);
                //obst.transform.localPosition =  Vector3.down * Time.deltaTime;
            }
        }
     }
        // Use this for initialization

        ObstaculoMovel oM = new ObstaculoMovel(true);

        void Start()
        {
            GameObject obstaculo;
            obstaculo = GameObject.Find("Obstaculo");

            oM.obst = obstaculo;
        }

        // Update is called once per frame
        void Update()
        {
            oM.movimentoVertical();

        }
  
}

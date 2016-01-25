using UnityEngine;
using System.Collections;

public class movimento : MonoBehaviour
{
    //Definição da Classe Obstáculo
    public class ObstaculoMovel
    {
        private bool praCima;
        private bool direita;
        private GameObject obst;
        private bool estado; //ativo-verdadeiro; inativo- false



        public ObstaculoMovel(bool pc, bool dir )
        {
            this.praCima = pc;
            this.direita = dir;
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
                if (obst.transform.localPosition.y <= 0.5f )
                    this.praCima = true;
                else
                    obst.transform.Translate(Vector3.down * Time.deltaTime, Space.World);
                //obst.transform.localPosition =  Vector3.down * Time.deltaTime;
            }
        }
        public void movimentoHorizontal()
        {
            if (obst.transform.localPosition.x <= 2.0f && direita)
                obst.transform.Translate(Vector3.right * Time.deltaTime, Space.World);
            if (obst.transform.localPosition.x >= 2.0f)
            {
                this.direita = false;
            }
            if (!this.direita)
            {
                print("Pra esquerda");
                if (obst.transform.localPosition.x <= -2.0f)
                    this.direita = true;
                else
                    obst.transform.Translate(Vector3.left * Time.deltaTime, Space.World);
            }

        }
        public void resetPos()
        {
            obst.transform.localPosition = new Vector3(0.0f, 0.5f, 0.0f);
        }
        public bool defineObjeto(string nomeObstaculo)
        {
            this.obst = GameObject.Find(nomeObstaculo);
            if (obst == null)
                return false;
            else
                return true;
        }
        public void defineEstado(bool estado) {
            this.estado = estado; 
        }
     }
        // Use this for initialization

        ObstaculoMovel oM = new ObstaculoMovel(true, true);

        void Start()
        {
            if (oM.defineObjeto("Obstaculo"))
               print("Objeto Obstaculo Encontrado e Definido");
            else
               print("Objeto Obstaculo Não Encontrado");
    }

        // Update is called once per frame
        void Update()
        {
            //oM.movimentoVertical();
            
            oM.movimentoHorizontal();
        }
  
}

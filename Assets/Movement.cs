using UnityEngine;

public class Movement : MonoBehaviour
{
    int frameAtual = 0;
    int inicioPulo = 0;
    bool pulando = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        public posicaoInicial = Vector3
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey("r")){
            this.transform.position = posicaoInicial
        }
        if (Input.GetKey("d") && Physics.CheckSphere(transform.position + Vector3.right * 0.2f, 0.85f)== false) {
            this.transform.Translate(-0.05f, 0, 0);
        }

        if (Input.GetKey("a") && Physics.CheckSphere(transform.position + Vector3.left * 0.2f, 0.85f) == false){
            this.transform.Translate(0.05f, 0, 0);
        }

        if (Input.GetKey("w") && Physics.CheckSphere(transform.position + Vector3.down * 0.2f, 0.87f) && pulando == false){
            pulando = true;
            inicioPulo = frameAtual;
        }

        int framesPassados = frameAtual - inicioPulo;

        if(pulando == true){
            if(framesPassados < 100){
            this.transform.Translate(0, 0, 0.05f);
            }else{
            pulando = false;
            }
        }

        frameAtual = frameAtual + 1;

        if(pulando == false && Physics.CheckSphere(transform.position + Vector3.down * 0.2f, 0.87f) == false){
            this.transform.Translate(0, 0, -0.05f);
        }

    }
}
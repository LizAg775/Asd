using UnityEngine;

public class Movement : MonoBehaviour
{
    int frameAtual = 0;
    int inicioPulo = 0;
    bool pulando = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("d")){
            this.transform.Translate(-0.05f, 0, 0);
        }

        if (Input.GetKey("a")){
            this.transform.Translate(0.05f, 0, 0);
        }

        if (Input.GetKey("w") && Physics.CheckSphere(transform.position, 2f) && pulando == false){
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

    }
}
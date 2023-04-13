using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ManagerPlayer : MonoBehaviour
{
    //Atributos
    public int life;
    public Slider barraVida;
    public float speed;


    Transform cam;
    public Joystick joystickMove;
    //public Joystick joystickGiro;
    public Transform player;
    public CharacterController controller;
    float x;
    float z;
    Vector3 move;
    float rotV;
    float rotH;
    public float speedGiro;



    private void Start()
    {
        cam = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        MovPlayer();
        Rotate();
        CheckLife();
    }
    public void MovPlayer()
    {
        x = joystickMove.Horizontal + Input.GetAxis("Horizontal");
        z = joystickMove.Vertical + Input.GetAxis("Vertical");
        move = player.right * x + player.forward * z;
        controller.Move(move * speed * Time.deltaTime);
        //Limitar moviemiento

        //if (this.transform.position.x < 4)
        //{
        //    transform.position = new Vector3(4, transform.position.y, transform.position.z);   //Izquierda
        //}
        //if (this.transform.position.x > -4)
        //{
        //    transform.position = new Vector3(-4, transform.position.y, transform.position.z);   //Derecha
        //}
    }
    public void Rotate()
    {
       // rotH = joystickGiro.Horizontal * speedGiro;
       //rotV = -(joystickGiro.Vertical * speedGiro);
        cam.Rotate(rotV, 0, 0);
        player.Rotate(0, rotH, 0);
    }
    public void CheckLife()                                                     //Checa si el jugador tiene vida
    {
        if (life <= 0)
        {
            Destroy(gameObject);                                               //Si no tiene vida, lo destruye.
            SceneManager.LoadScene(2);                                         // Abre posmortem
        }
    }

   
    private void OnTriggerEnter(Collider other)
    {
        //Si el jugador toca al destructor, pierde toda la vida.
        if (other.tag == "Destroyer")
        {
            life = 0;
        }
        if (other.tag == "Enemy")
        {
            life--;
            barraVida.value = life;
        }
        if (other.tag == "Astro")                                             //Si lo toca el enemigo, le baja uno de vida al jugador.
        {
            life--;
            barraVida.value = life;
        }
    }

}

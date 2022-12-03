using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Car : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float speedGamePerSecond = 0.2f;
    [SerializeField] private float turnSpeed = 200f;
    private int steerValue;

    // Update is called once per frame
    void Update()
    {
        speed += speedGamePerSecond * Time.deltaTime;
        transform.Rotate(0,(steerValue*turnSpeed)*Time.deltaTime,0f);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider c) {
        if(c.CompareTag("Obstacle")){
            SceneManager.LoadScene(0);
        }
    }

    public void Steer(int value){
        steerValue=value;
    }
}

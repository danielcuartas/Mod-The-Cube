using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    float timer = 0;
    public float timeForTimer = 1.5f;
    float startTime = 0;
    public MeshRenderer Renderer;
    float positionX;
    float positionY;
    float positionZ;
    Vector3 position;
    Material material;

    float randomAlpha;
    float randomR;
    float randomG;
    float randomB;

    float randomScaleX;
    float randomScaleY;
    float randomScaleZ;



    void Start()
    {
        material = Renderer.material;
    }
    
    void Update()
    {
        timer += Time.deltaTime;

        Debug.Log("timer: " + (timer-startTime));
        
        if (timer >= (startTime + timeForTimer))
        {
            positionX = Random.Range(-10f, 10f);
            positionY = Random.Range(0f, 10f);
            positionZ = Random.Range(-10f, 10f);
            position = new Vector3(positionX, positionY, positionZ);

            transform.position = position;


            randomR = Random.Range(0f, 1f);
            randomG = Random.Range(0f, 1f);
            randomB = Random.Range(0f, 1f);
            randomAlpha = Random.Range(0f, 1f);

            material.color = new Color(randomR, randomG, randomB, randomAlpha);

            randomScaleX = Random.Range(1f, 5f);
            randomScaleY = Random.Range(1f, 5f);
            randomScaleZ = Random.Range(1f, 5f);

            transform.localScale = new Vector3(randomScaleX, randomScaleY, randomScaleZ);

            startTime = timer;
        }

        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
        

        
    }
}

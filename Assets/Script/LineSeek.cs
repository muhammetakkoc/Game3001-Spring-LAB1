using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LineSeek : MonoBehaviour
{
    float speed = 5f;
    

    void Start()
    {
        
        
        
    }

    public void ChangeSceneStart()
    {
        SceneManager.LoadScene(2);
    }
    public void ChangeSceneEnd()
    {
        SceneManager.LoadScene(1);
    }
    public void ChangeScenePlay()
    {
        SceneManager.LoadScene(0);
    }

    void Update()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.z = 0.0f;
        transform.position = Vector3.MoveTowards(transform.position, mouse, speed*Time.deltaTime );

        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"Trigger between {name} and {collision.gameObject.name} started!");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log($"Trigger between {name} and {collision.gameObject.name} persisting...");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log($"Trigger between {name} and {collision.gameObject.name} ended!");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class Teleport : MonoBehaviour
{
    [SerializeField] private UnityEvent OnPortal;
    private GameObject ball;
    public GameObject teleport_exit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("dfghj");
        if (other.gameObject.name == "Ball")
        {
            ball = other.gameObject;
            other.gameObject.SetActive(false);
            StartCoroutine(WaitForTeleport());
            OnPortal.Invoke();
        }
    }
    IEnumerator WaitForTeleport(){

    


        yield return new WaitForSeconds(1f);


        ball.transform.position = teleport_exit.transform.position;
        ball.SetActive(true);
    }
}

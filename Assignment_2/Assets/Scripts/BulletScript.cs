using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject explosion;
    private GameObject expl;
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

        if(other.gameObject.transform.tag == "Enemy")
        {
            expl = Instantiate(explosion);
            expl.transform.position = other.transform.position;
            expl.gameObject.SetActive(true);
            other.gameObject.SetActive(false);
        }
        
    }
}

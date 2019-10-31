using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBall : MonoBehaviour
{
    private AudioSource source;
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
        Instantiate(explosion, transform.position, Quaternion.identity);
        GameObject.Find("GameManager").GetComponent<GameManager>().ScoreUp();
    }
}

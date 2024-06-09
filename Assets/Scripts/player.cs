using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public AudioClip explode;

    private AudioSource audioSource;

    public Rigidbody2D rigid;
    [SerializeField]
    private float _upspeed = 5f;
    public scoremanager _scoremanager;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(-1.57f, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        fly();
        if(transform.position.y > 3 || transform.position.y < -2)
        {
            destroy();
        }
        _scoremanager = GameObject.Find("scoremanager").GetComponent<scoremanager>();
    }
    void fly()
    {
        if (Input.GetKey("space"))
        {

            rigid.AddForce(Vector2.up * _upspeed);
        }
    }
    void destroy()
    {
        Destroy(this.gameObject);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "donthit")
        {
            destroy();
            explodemusic();
            _scoremanager.gameover();
        }
    }
    public void explodemusic()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = explode;
        audioSource.loop = false;
        audioSource.volume = 1f;  // Set the volume level as needed
        audioSource.Play();
    }
    
   
      
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject obstacle;
    [SerializeField]
    private float _spawnrate = 2;
    private float _timer;
    [SerializeField]
    private float _shift = 5;
    private player _player;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("player").GetComponent<player>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
            if (_timer < _spawnrate)
            {
                _timer = _timer + Time.deltaTime;
            }
            else
            {

                float low = transform.position.y - _shift;
                float high = transform.position.y + _shift;
                float y;
                y = Random.Range(low, high);
                Instantiate(obstacle, new Vector2(transform.position.x, y), Quaternion.identity);
                _timer = 0;
            }
        


    }
}

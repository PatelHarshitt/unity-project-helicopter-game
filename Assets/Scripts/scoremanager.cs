using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoremanager : MonoBehaviour
{[SerializeField]
    private int score;
    [SerializeField]
   private Text scoretext;
    [SerializeField]
    private Text pressR;
    [SerializeField]
    private Text pressM;
    private player player;
    [SerializeField]
    private Text gameovertext;
    // Start is called before the first frame update
    void Start()
    {
        pressR.gameObject.SetActive(false);
        pressM.gameObject.SetActive(false);
        gameovertext.gameObject.SetActive(false);
        player = GameObject.Find("player").GetComponent<player>();
    }

    // Update is called once per frame
    void Update()
    {
      if(player == null)
        {
            gameover();
        }
    }
    public void increase_score()
    {
        score = score + 1;
        scoretext.text = score.ToString();
        Debug.Log(score);

    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void mainmenu()
    {
        SceneManager.LoadScene("mainmenu");
    }
    public void gameover()
    {
        gameovertext.gameObject.SetActive(true);
        pressM.gameObject.SetActive(true);
        pressR.gameObject.SetActive(true);
        if (Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            mainmenu();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Timers;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class GameController : MonoBehaviour

{
    public GameObject coinprefab;
    public float spawntime = 1f;
    public float spawnmin = 14f;
    public float spawnmax = 20f;
    private float gametimer;
    public TextMeshProUGUI Pointtext;
    public int points;
    public static GameController instance;

    // Start is called before the first frame update

    private void Start()
    {
        
    }
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        gametimer += Time.deltaTime;
        if (gametimer >= spawntime)
        { SpawnCoin();
            gametimer = 0f;
        }
    }
    private void SpawnCoin()
    { float randompos = Random.Range(spawnmin, spawnmax);
    Vector3 spawnpos = new Vector3(randompos, 14.7f, 0f);
        Instantiate (coinprefab, spawnpos, Quaternion.identity);
}
   
    public void UpdateScore()
    {
        points++;
        Pointtext.text = "Points:" + points; }
    
}

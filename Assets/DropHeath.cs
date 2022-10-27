using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DropHeath : MonoBehaviour
{
    public GameObject healthBooster;
    public Transform HealSpawnPoint;

    void Start()
    {
        HealSpawnPoint = GameObject.Find("HealSpawnPoint").transform;
        Scene currentScene = SceneManager.GetActiveScene ();
        string sceneName = currentScene.name;
        if (sceneName == "BossScene")
        {
            
            InvokeRepeating("Spawn", 10f, 10f);
        }
    }

    void Spawn()
    {
        Instantiate(healthBooster, HealSpawnPoint.position, HealSpawnPoint.rotation);
    }
}

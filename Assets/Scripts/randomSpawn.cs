using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSpawn : MonoBehaviour {

    public GameObject[] respawns;
    public GameObject respawnPrefab;

    void Start () {
        respawns = GameObject.FindGameObjectsWithTag ("spawnPoint");

        for (int i = 0; i < 20; i++) {
            int randomSpawnPoint = Random.Range (0, 5);
            Debug.Log ("Spawn Point ID:" + randomSpawnPoint);
            Instantiate (respawnPrefab, respawns[randomSpawnPoint].transform.position, Quaternion.identity);
        }
    }

}
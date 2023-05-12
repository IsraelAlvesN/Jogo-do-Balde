using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public float interval = 1f;
    private float cooldown = 0f;
    public List<GameObject> prefabs;
    public Vector3 originPoint = new Vector3(0, 0, 0);

    void Start()
    {
        
    }

    void Update()
    {
        if (!GameManager.Instance.isGameActive)
        {
            return;
        }
        cooldown -= Time.deltaTime;
        if (cooldown <= 0)
        {
            cooldown = interval;
            SpawnBall();
        }
    }

    private void SpawnBall()
    {
        //Get prefab
        int prefabIndex = Random.Range(0, prefabs.Count);
        GameObject prefab = prefabs[prefabIndex];
        //Get position
        var gameWidth = GameManager.Instance.gameWidth;
        float xOffSet = Random.Range(-gameWidth / 2f, gameWidth / 2f);
        Vector3 position = originPoint + new Vector3(xOffSet, 0, 0);

        //Get rotation
        Quaternion rotation = prefab.transform.rotation;

        Instantiate(prefab, position, rotation);
    }
}

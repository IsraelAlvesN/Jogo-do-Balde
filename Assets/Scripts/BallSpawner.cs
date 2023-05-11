using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public float interval = 1f;
    private float cooldown = 0f;
    public List<GameObject> prefabs;
    public Vector3 originPoint = new Vector3(0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
        Vector3 position = originPoint;
        //Get rotation
        Quaternion rotation = prefab.transform.rotation;

        Instantiate(prefab, position, rotation);
    }
}

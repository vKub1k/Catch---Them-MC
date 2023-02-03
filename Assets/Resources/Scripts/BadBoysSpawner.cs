using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadBoysSpawner : MonoBehaviour
{
    [SerializeField] private GameObject badBoyPrefab;
    [SerializeField] private int badBoysQnt = 100;
    [SerializeField] private float spawnRadius = 200;
    
    public void _StartSpawn()
    {
        for (int i = 0; i < badBoysQnt; i++)
        {
            SpawnBadBoy();
        }
    }
    
    private void SpawnBadBoy()
    {
        var badBoyGameObject = Instantiate(badBoyPrefab, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
        var badBoyScript = badBoyGameObject.GetComponent<BadBoy>();
        
        var currentPosition = badBoyScript.transform.localPosition;
        
        currentPosition.x = Random.Range(-spawnRadius, spawnRadius);
        currentPosition.y = Random.Range(-spawnRadius, spawnRadius);
        badBoyScript.transform.localPosition = currentPosition;
        badBoyScript.transform.SetParent(this.transform, false);
    }

    public void _CleanUp()
    {
        foreach (Transform t in this.transform) {
            GameObject.Destroy(t.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnerObject : MonoBehaviour
{

    public GameObject[] objectsToSpawn;
    private float objectSizeMax = 0.5F;
    private PlacementIndicator placementIndicator;

    // Start is called before the first frame update
    void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            int randomIndex = Random.Range(0, objectsToSpawn.Length);
            
            GameObject obj = Instantiate(
            objectsToSpawn[randomIndex],
            placementIndicator.transform.position,
            placementIndicator.transform.rotation);

            float randomSize = Random.Range(0, objectSizeMax);
            obj.transform.localScale = Vector3.one * randomSize;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using Vuforia;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour, ITrackableEventHandler
{
    public Vector2 GameArea;
    public GameObject objectPrefab;
    private TrackableBehaviour mTrackableBehaviour;
    private GameObject CurrentAnimal;
    public GameObject floor;
    // Start is called before the first frame update
    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    private void SpawnObjects ()
    {
       // for (int i = 0; i < 3; i++)
        //{
            GameObject spawnedObject = Instantiate(objectPrefab) as GameObject;

            spawnedObject.transform.position = new Vector3(floor.transform.position.x,floor.transform.position.y,floor.transform.position.z);
            CurrentAnimal = spawnedObject;
       // }
    }
    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED)
        {
            SpawnObjects();
        }
        else
        {
            Destroy(CurrentAnimal);
        }
    }

    // Update is called once per frame
    void Update()   
    {
        CurrentAnimal.transform.position = new Vector3((floor.transform.position.x + Random.Range(0.3f,0.3f)), (floor.transform.position.y - 0.5f), (floor.transform.position.z + Random.Range(0.3f, 0.3f)));
    }
}

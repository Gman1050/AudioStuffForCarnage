using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectEntityDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float destroyerTime = GetComponent<AudioSource>().clip.length;
        Destroy(gameObject, destroyerTime);
    }
}

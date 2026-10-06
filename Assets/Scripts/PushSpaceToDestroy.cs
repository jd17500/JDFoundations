using UnityEngine;
// This script is to destroy a game object using the spacebar

public class PushSpaceToDestroy : MonoBehaviour
{

    public GameObject gameObjectToDestroy;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Destroy(gameObject);
           // Destroy(this.gameObject);
         Destroy(gameObjectToDestroy);
        }
    }
}

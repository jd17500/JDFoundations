using UnityEngine;

public class ClickToDestroy : MonoBehaviour
{ 
   
        public GameObject clickObjToDestroy;

        void OnMouseDown()
        {
            Debug.Log("Object was clicked");
           // Debug.LogError("Object was clicked");This log error will stop play
           // Debug.LogWarning("Object was clicked");

           Destroy(this.clickObjToDestroy);
        }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FloorDungeon : MonoBehaviour
{
    private IEnumerator coroutine;
    bool isPlayerInRange = false;
    public GameObject tip;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            isPlayerInRange = true;
            reset(other);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            isPlayerInRange = false;
        }
    }
    private void reset(Collider player){
        if (Checkpoint.isFirstPartDone)
        {
            float positionX = PlayerPrefs.GetFloat("Xvalue");
            float positionY = PlayerPrefs.GetFloat("Yvalue");
            float positionZ = PlayerPrefs.GetFloat("Zvalue");
            player.transform.position = new Vector3(positionX, positionY, positionZ);
        }
        else
        {
       SceneManager.LoadScene(sceneName:"Dungeon");
        }
        
    }
}

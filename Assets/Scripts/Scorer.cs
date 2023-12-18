using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scorer : MonoBehaviour
{
   int hits = -2;

   private void OnCollisionEnter(Collision other)
   {
        if(other.gameObject.tag != "Hit" || other.gameObject.tag != "Finish")
        {
                hits++;
                Debug.Log("You've bumped into a thing this many times:" + hits);       
        }
        if(hits == 3)
        {
                ReloadLevel();
        }
   }
   void ReloadLevel()
    {
        int cussentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        //SceneManager.LoadScene(0);
        SceneManager.LoadScene(cussentSceneIndex);
    }
}

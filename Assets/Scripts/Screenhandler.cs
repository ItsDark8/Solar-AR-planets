using UnityEngine;
using UnityEngine.SceneManagement;
public class Screenhandler : MonoBehaviour
{
    public void LoadSpecificScene(string ScreenName) 
    {
       SceneManager.LoadScene(ScreenName);
    }
}

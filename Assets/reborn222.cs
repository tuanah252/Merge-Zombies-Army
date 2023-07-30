using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class reborn222 : MonoBehaviour
{
    // Start is called before the first frame update
    public void restartscene()
    {
        // Lấy index của scene hiện tại
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        
        // Tải lại scene có cùng index để restart
        SceneManager.LoadScene(currentSceneIndex);
    }

}

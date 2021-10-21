using UnityEngine;

public class DDL : MonoBehaviour
{    
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);        
    }
}

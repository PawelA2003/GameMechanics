using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; 
    public int CherryCounter = 0;       
    public bool HasEatenFirstCherry = false; 

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
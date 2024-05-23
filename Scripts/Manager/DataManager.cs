using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public int CharacterNum;

    private void Awake()
    {
        if(Instance == null)
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

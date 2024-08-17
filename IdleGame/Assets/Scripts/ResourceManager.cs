using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResourceManager : MonoBehaviour
{
    public TextMeshProUGUI woodCount;
    private int woodCollected = 0;

    public TextMeshProUGUI coinCount;

    // Start is called before the first frame update
    void Start()
    {
        woodCount.text = PlayerPrefs.GetInt("wood").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetWood()
    {
        woodCollected++;
        PlayerPrefs.SetInt("wood", woodCollected);
        woodCount.text = woodCollected.ToString();
    }
}

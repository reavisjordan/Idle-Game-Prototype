using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResourceManager : MonoBehaviour
{
    public TextMeshProUGUI woodCount;
    private int wood;

    public TextMeshProUGUI coinCount;
    private int coins;

    private float workSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator HarvestWood()
    {
        GetWood();
        yield return new WaitForSeconds(workSpeed);
    }

    public void GetWood()
    {
        wood++;
        PlayerPrefs.SetInt("wood", wood);
        woodCount.text = wood.ToString();
    }

    public void SellWood()
    {
        coins += wood;
        PlayerPrefs.SetInt("coins", coins);
        coinCount.text = coins.ToString();

        wood = 0;
        PlayerPrefs.SetInt("wood", wood);
        woodCount.text = wood.ToString();
    }

    public void ClearUserData()
    {
        PlayerPrefs.DeleteAll();
    }

    public void UpdateUI()
    {
        wood = PlayerPrefs.GetInt("wood");
        woodCount.text = PlayerPrefs.GetInt("wood").ToString();

        coins = PlayerPrefs.GetInt("coins");
        coinCount.text = PlayerPrefs.GetInt("coins").ToString();
    }
}

using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    public GameObject bow;
    public PlayerAttack PlayerAttack;
    private bool BowEnabled = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        EnableBow(false);
    }

    // Update is called once per frame
    void Update()
    {
        float scrolll = Input.mouseScrollDelta.y;
        if (scrolll > 0f || scrolll < 0f)
        {
            BowEnabled = !BowEnabled;
            EnableBow(BowEnabled);

        }
    }
    void EnableBow(bool enabled)
    {
        bow.SetActive(enabled);
        PlayerAttack.enabled = !enabled;
    }    
}

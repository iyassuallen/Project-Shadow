using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Image healthBar;
    public float health, maxHealth;
    public float spikeCost;
    public float shadowCost;
    public float chargeRate;
    public float chargeTime = 1f;
    private Coroutine recharge;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator RechargeHealth()
    {
        yield return new WaitForSeconds(chargeTime);

        while (health < maxHealth)
        {
            health += chargeRate / 10f;
            if (health > maxHealth) health = maxHealth;
            healthBar.fillAmount = health / maxHealth;
            yield return new WaitForSeconds(.1f);
        }
    }
}

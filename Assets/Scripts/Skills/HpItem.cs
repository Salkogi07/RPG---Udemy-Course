using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpItem : Skill
{
    [Header("HpItems cooldown")]
    float itemCooldown = 60f;
    private float lastTimeUsedFlask;

    private PlayerStats playerhp;

    public float flaskCooldown { get; private set; }
    public Slider Slider1;
    public Slider Slider2;

    private void Awake()
    {
        playerhp = GameObject.Find("Player").GetComponent<PlayerStats>();
    }

    public void UseFlask()
    {

        bool canUseFlask = Time.time > lastTimeUsedFlask + flaskCooldown;

        if (canUseFlask)
        {
            playerhp.currentHealth += 30;
            if (playerhp.currentHealth >= 125)
            {
                playerhp.currentHealth = 125;
            }
            Slider1.value = playerhp.currentHealth;
            Slider2.value = playerhp.currentHealth;

            flaskCooldown = itemCooldown;
            lastTimeUsedFlask = Time.time;
        }
        else
            Debug.Log("Flask on cooldown;");
    }
}

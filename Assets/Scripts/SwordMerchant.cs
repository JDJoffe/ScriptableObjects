using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SwordMerchant : MonoBehaviour
{
    [SerializeField] private Text swordName;
    [SerializeField] private Text description;
    [SerializeField] private Image icon;
    [SerializeField] private Text goldCost;
    [SerializeField] private Text attackDamage;
    [SerializeField] public static AudioClip swordSound;
    // sound stuff
    [SerializeField] private AudioSource audio;
    [SerializeField] private float clipTimer;

   // when you click on the sword do the following
    public void UpdateDisplayUI(SwordData swordData)
    {
        swordName.text = swordData.SwordName;
        description.text = swordData.Description;
        icon.sprite = swordData.Icon;
        goldCost.text = swordData.GoldCost.ToString();
        attackDamage.text = swordData.AttackDamage.ToString();
        audio.clip = swordData.SwordSound;
        audio.Play();
    }

}

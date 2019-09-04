using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// add the scriptableobject to the asset menu by giving the class this attribute
[CreateAssetMenu(fileName = "New SwordData", menuName = "Sword Data", order = 51)]
public class SwordData : ScriptableObject
{
    #region var
    // serializefield allows you to see private vars in the inspector
    // you can use the inspector to change values without other scripts having access

    [SerializeField] private string swordName;
    [SerializeField] private string description;
    [SerializeField] private Sprite icon;
    [SerializeField] private int goldCost;
    [SerializeField] private int attackDamage;
    #endregion

   public string SwordName { get { return swordName; } }
    public string Description { get { return description; } }
    public Sprite Icon { get { return icon; } }
    public int GoldCost { get { return goldCost; } }
    public int AttackDamage { get { return attackDamage; } }
  
}

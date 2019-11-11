using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Game Event", menuName = "Game Event", order =52)]
public class GameEvent : ScriptableObject
{
    private SwordData sworddata;
    private List<GameAction> listeners = new List<GameAction>();
   // list of total listeners and for each one invoke the unity event
    public void Raise()
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();        
        }
    }
    // not needed
   public void playsound()
    {

    }
    // add a listener for the gameevent
    public void RegisterListener(GameAction listener)
    {
        listeners.Add(listener);
    }
    // remove the lsitener 
    public void UnRegisterListener(GameAction listener)
    {
        listeners.Remove(listener);
    }
   
}

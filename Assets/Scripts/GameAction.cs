using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[System.Serializable]
public class GameAction
{
    #region var
    [HideInInspector] public string name;
    public GameEvent gameEvent;
    public UnityEvent gameAction;
    #endregion
    // update the current gameevent
   public void Update()
    {
        if (gameEvent)
        {
            name = gameEvent.name;
        }
    }
    // register current event that is happening
    public void RegisterListener()
    {
        gameEvent.RegisterListener(this);
    }
    // unregister current event that is happening
    public void UnRegisterListener()
    {
        gameEvent.UnRegisterListener(this);
    }
    // invoke the gameaction (play sound etc)
    public void OnEventRaised()
    {
        gameAction.Invoke();
    }
}

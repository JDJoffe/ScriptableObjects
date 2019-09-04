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

   public void Update()
    {
        if (gameEvent)
        {
            name = gameEvent.name;
        }
    }

    public void RegisterListener()
    {
        gameEvent.RegisterListener(this);
    }
    public void UnRegisterListener()
    {
        gameEvent.UnRegisterListener(this);
    }
    public void OnEventRaised()
    {
        gameAction.Invoke();
    }
}

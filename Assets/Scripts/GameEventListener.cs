using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//runs in update in editmode
[ExecuteInEditMode]
public class GameEventListener : MonoBehaviour
{
    [SerializeField] private GameAction[] actions;
    // allow it to work in the unity editor
    private void Update()
    {
        if (Application.isEditor)
        {
            foreach (var action in actions)
            {
                // call update from other script
                action.Update();
            }
        }
    }

    private void OnEnable()
    {
        // listlen for gameevents that are atatched to the scriptable objects
        foreach (var action in actions)
        {
            action.RegisterListener();
        }
    }

    private void OnDisable()
    {
        // listlen for gameevents that are atatched to the scriptable objects
        foreach (var action in actions)
        {
            action.UnRegisterListener();
        }
    }
}

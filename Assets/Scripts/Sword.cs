using UnityEngine;
using UnityEngine.Events;
public class Sword : MonoBehaviour
{
    [SerializeField] private UnityEvent onMouseDown;

    // called when the user clicks the mouse
    private void OnMouseDown()
    {
        onMouseDown.Invoke();
    }
}

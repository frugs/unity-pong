using UnityEngine;
using System;
using System.Collections.Generic;

namespace Pong.Input
{
    public class InputHandler
    {
        private KeyCode InputKey;
    
        private List<Action> OnKeyDownActions = new List<Action>();
        private List<Action> OnKeyUpActions = new List<Action>();
    
        public InputHandler(KeyCode inputKey)
        {
            InputKey = inputKey;
        }
    
        public void RegisterAction(Action keyDown, Action keyUp)
        {
            OnKeyDownActions.Add(keyDown);
            OnKeyUpActions.Add(keyUp);
        }
    
        public void HandleInput()
        {
            if (UnityEngine.Input.GetKeyDown(InputKey)) {
    
                foreach (Action onKeyDown in OnKeyDownActions) {
                    onKeyDown.Invoke();
                }
            } else if (UnityEngine.Input.GetKeyUp(InputKey)) {
    
                foreach (Action onKeyUp in OnKeyUpActions) {
                    onKeyUp.Invoke();
                }
            }
        }
    }
}


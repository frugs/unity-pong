using UnityEngine;
using System;
using System.Collections.Generic;

namespace Pong.Input
{
    public class InputManager : MonoBehaviour
    {
        void Start()
        {
        }
    
        void Update()
        { 
            foreach (InputHandler inputHandler in InputHandlers.GetInputHandlers()) {
                inputHandler.HandleInput();
            }
        }
    }
}


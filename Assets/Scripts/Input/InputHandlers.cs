using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Pong.Input
{
    public class InputHandlers : IEnumerable<InputHandler>
    {
        private static InputHandlers GameInputHandlers = new InputHandlers();
    
        private Dictionary<KeyCode, InputHandler> InputHandlerDictionary = new Dictionary<KeyCode, InputHandler>();
    
        private InputHandlers()
        {
        }

        //Not thread safe, don't call from child thread   
        public static InputHandlers GetInputHandlers()
        {
            return GameInputHandlers;
        }
    
        public IEnumerator<InputHandler> GetEnumerator()
        {
            return InputHandlerDictionary.Values.GetEnumerator();
        }
    
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public InputHandler InputHandlerFor(KeyCode keyCode)
        {
            InputHandler result;
            
            if (!InputHandlerDictionary.TryGetValue(keyCode, out result)) {
                result = new InputHandler(keyCode);
                InputHandlerDictionary.Add(keyCode, result);
            }
            return result;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BatCave
{
    public class BatCompositeControler : BatController {
        
        [SerializeField] private BatController _mouseController = ScriptableObject.CreateInstance<BatMouseController>();
        [SerializeField] private BatController _keyboardController = ScriptableObject.CreateInstance<BatKeyboardController>();
        
        // Use this for initialization
        void Start () {
		
        }
	
        // Update is called once per frame
        void Update () {
		
        }

        public override bool WantsToFlyUp()
        {
            return _mouseController.WantsToFlyUp() || _keyboardController.WantsToFlyUp();
        }
    }

}

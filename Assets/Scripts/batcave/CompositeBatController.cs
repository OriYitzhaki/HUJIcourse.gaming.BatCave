using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BatCave
{
    [CreateAssetMenu(menuName = "Bat Controller/Composite")]
    public class BatCompositeControler : BatController {
        
        [SerializeField] private BatController _mouseController = CreateInstance<BatMouseController>();
        [SerializeField] private BatController _keyboardController = CreateInstance<BatKeyboardController>();
        
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

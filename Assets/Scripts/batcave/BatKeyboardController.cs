using System;
using System.Collections;
using System.Collections.Generic;
using BatCave;
using Infra.Gameplay.UI;
using UnityEngine;

namespace BatCave
{
    [CreateAssetMenu(menuName = "Bat Controller/Keyboard")]
    public class BatKeyboardController : BatController
    {
        private bool _wantsToFlyUp;

        public override bool WantsToFlyUp()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _wantsToFlyUp = true;
            }
            else if (Input.GetKeyUp(KeyCode.Space))
            {
                _wantsToFlyUp = false;
            }
            return _wantsToFlyUp;
        }
    }
}
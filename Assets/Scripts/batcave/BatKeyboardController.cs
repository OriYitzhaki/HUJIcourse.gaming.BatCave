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
        [SerializeField] private bool _wantsToFlyUp;
        [SerializeField] private string _listhenTo = "space";

        public override bool WantsToFlyUp()
        {
            return _wantsToFlyUp;
        }

        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            _wantsToFlyUp = Input.GetKeyDown(KeyCode.Space);
        }
    }
}

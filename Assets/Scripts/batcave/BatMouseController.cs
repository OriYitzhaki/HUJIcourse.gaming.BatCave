﻿using System.Collections;
using System.Collections.Generic;
using Infra.Gameplay.UI;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BatCave
{
    [CreateAssetMenu(menuName = "Bat Controller/Mouse")]
    public class BatMouseController : BatController {
        [SerializeField] private bool _wantsToFlyUp;
        private bool _isRegister;
        
        
        public override bool WantsToFlyUp()
        {
            return _wantsToFlyUp;
        }
        
        // Use this for initialization

        void Start ()
        {
            if (!_isRegister)
            {
                RegisterSelf();
            }
        }

        private void OnEnable()
        {
            if (!_isRegister)
            {
                RegisterSelf();
            }
   
        }

        private void Awake()
        {
            if (!_isRegister)
            {
                RegisterSelf();
            }
            
        }

        private void RegisterSelf()
        {
            GameInputCapture.OnTouchDown += OnTouchDown;
            GameInputCapture.OnTouchUp += OnTouchUp;
            _isRegister = true;
        }


        private void OnDisable()
        {
            if (!_isRegister) return;
            GameInputCapture.OnTouchDown -= OnTouchDown;
            GameInputCapture.OnTouchUp -= OnTouchUp;
            _isRegister = false;
        }

        private void OnDestroy()
        {
            if (!_isRegister) return;
            GameInputCapture.OnTouchDown -= OnTouchDown;
            GameInputCapture.OnTouchUp -= OnTouchUp;
            _isRegister = false;
        }

        private void OnTouchUp(PointerEventData obj)
        {
            _wantsToFlyUp = false;   
        }

        private void OnTouchDown(PointerEventData obj)
        {
            _wantsToFlyUp = true;   
            
        }
        
        // Update is called once per frame
        void Update () {
            
        }
    }


}
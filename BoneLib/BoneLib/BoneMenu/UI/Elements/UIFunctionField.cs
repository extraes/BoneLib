﻿using System;
using TMPro;

using UnityEngine;
using UnityEngine.UI;

using BoneLib.BoneMenu.Elements;

namespace BoneLib.BoneMenu.UI
{
    [MelonLoader.RegisterTypeInIl2Cpp]
    public class UIFunctionField : UIElement
    {
        public UIFunctionField(IntPtr ptr) : base(ptr) { }

        public override ElementType Type => ElementType.Function;

        private Button _functionButton;

        private void Awake()
        {
            _functionButton = transform.Find("Button").GetComponent<Button>();

            SetupListeners();
        }

        private void SetupListeners()
        {
            Action onPressed = () => _element?.OnSelectElement();

            if(_functionButton != null)
            {
                _functionButton.onClick.AddListener(onPressed);
            }
        }
    }
}

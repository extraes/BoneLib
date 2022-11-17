﻿using System;

using UnityEngine;

namespace BoneLib.BoneMenu.Elements
{
    public class FunctionElement : MenuElement
    {
        public FunctionElement(string name, Color color, Action action) : base(name, color)
        {
            Name = name;
            Color = color;
            Action = action;
        }

        public override ElementType Type => ElementType.Function;

        public Action Action { get; private set; }

        public override void OnSelectElement()
        {
            SafeActions.InvokeActionSafe(Action);
        }
    }
}

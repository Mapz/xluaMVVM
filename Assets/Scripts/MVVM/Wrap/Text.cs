using UnityEditor;
using UnityEngine;
using System.Collections.Generic;
using System;
using XLua;
using xLuaMVVM.Assets.MVVM;
public delegate void ValueChangeDelegate(object oldValue, object newValue);

namespace xLuaMVVM.Assets.MVVM.Wrap
{
    [AddComponentMenu("UIMVVM/Text", 10)]
    public class Text : UnityEngine.UI.Text, HijackValue
    {
        public override string text
        {
            get
            {
                return base.text;
            }
            set
            {
                if (base.text == value) return;
                if (on_change_text != null)
                    on_change_text(base.text, value);
                base.text = value;
            }
        }

        // [CSharpCallLua]
        public ValueChangeDelegate on_change_text;


    }
}
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Mainscripts
{
    public class ButtonScript : MonoBehaviour
    {
        private Button _button;
        public Action Action { get; set; }

        void Start()
        {
            _button = GetComponent<Button>();
            _button.onClick.AddListener(() => Action.Invoke());
        }
    }
}
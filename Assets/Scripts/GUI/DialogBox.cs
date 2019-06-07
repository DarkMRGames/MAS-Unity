using Assets.Scripts.Api;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.GUI
{
    public class DialogBox : MonoBehaviour
    {
        #region Fields and props

        public GameObject nameBox, textBox;
        public GameObject canvas_nameBox, canvas_textBox; 
        public float timeToType = 10;

        private float _timeTypeStart;
        private string _realText;
        private string _visibleText;    
        private bool _typeEnded;

        string MonikaName { get; set; }
        public string Text {
            get
            {
                return _realText;
            }
            set
            {
                _realText = value;

                if (string.IsNullOrEmpty(_realText))
                {
                    _typeEnded = true;
                    return;
                }

                _visibleText = string.Empty;
                _timeTypeStart = Time.time;
                _typeEnded = false;

                SetVisible(true);
            }
        }
        #endregion

        private void Awake()
        {
            Global.Dialog = this;
        }

        private void Start()
        {
            Global.Events.GUI.InterfaceVisibiltyChanged += OnInterfaceVisibilityChanged;

            MonikaName = "Monika";

            SetVisible(true);
        }

        /*private void OnDestroy()
        {
            Global.Dialog = null;
            Global.Events.GUI.InterfaceVisibiltyChanged -= OnInterfaceVisibilityChanged;
        }*/

        private void OnGUI()
        {
            if (string.IsNullOrEmpty(_realText) || textBox == null || !textBox.activeSelf)
                return;

            canvas_textBox.GetComponent<Text>().text = _visibleText;
        }

        private void Update()
        {
            if (_typeEnded || string.IsNullOrEmpty(_realText) || textBox == null)
            {
                Global.Monika.Talking = false;
                return;
            }
            else
                Global.Monika.Talking = true;

            int nextChar = (int) ((Time.time - _timeTypeStart) / timeToType);
            _visibleText = _realText.Substring(0, nextChar);
            _typeEnded = _realText.Length == nextChar;
        }

        private void SetVisible(bool visible)
        {
            visible = visible && !string.IsNullOrEmpty(_realText);
            nameBox.SetActive(visible);
            textBox.SetActive(visible);
            canvas_nameBox.SetActive(visible);
            canvas_textBox.SetActive(visible);
        }

        private void OnInterfaceVisibilityChanged(object sender, InterfaceVisibiltyEventArgs e)
        {
            SetVisible(e.Visible);
        }
    }
}
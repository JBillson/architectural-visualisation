namespace VRTK.UnityEventHelper
{
    using UnityEngine;
    using UnityEngine.Events;
    using System;
    using UnityEditor;

    [AddComponentMenu("VRTK/Scripts/Utilities/Unity Events/VRTK_ControllerEvents_UnityEvents")]
    public class VRTK_ControllerEvents_UnityEvents : VRTK_UnityEvents<VRTK_ControllerEvents>
    {
        [Serializable]
        public sealed class ControllerInteractionEvent : UnityEvent<object, ControllerInteractionEventArgs> { }

        public TriggerInput trigger;
        public GripInput grip;
        public TouchpadInput touchpad;
        public ButtonOneInput buttonOne;
        public ButtonTwoInput buttonTwo;
        public StartMenuInput startMenu;
        public OnAliasInput onAlias;
        public ControllerEvents controllerEvents;

        [System.Serializable]
        public class TriggerInput
        {
            public ControllerInteractionEvent OnTriggerPressed = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnTriggerReleased = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnTriggerTouchStart = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnTriggerTouchEnd = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnTriggerHairlineStart = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnTriggerHairlineEnd = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnTriggerClicked = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnTriggerUnclicked = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnTriggerAxisChanged = new ControllerInteractionEvent();
        }

        [System.Serializable]
        public class GripInput
        {
            public ControllerInteractionEvent OnGripPressed = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnGripReleased = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnGripTouchStart = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnGripTouchEnd = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnGripHairlineStart = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnGripHairlineEnd = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnGripClicked = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnGripUnclicked = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnGripAxisChanged = new ControllerInteractionEvent();
        }

        [System.Serializable]
        public class TouchpadInput
        {
            public ControllerInteractionEvent OnTouchpadPressed = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnTouchpadReleased = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnTouchpadTouchStart = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnTouchpadTouchEnd = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnTouchpadAxisChanged = new ControllerInteractionEvent();
        }

        [System.Serializable]
        public class ButtonOneInput
        {
            public ControllerInteractionEvent OnButtonOnePressed = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnButtonOneReleased = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnButtonOneTouchStart = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnButtonOneTouchEnd = new ControllerInteractionEvent();
        }

        [System.Serializable]
        public class ButtonTwoInput
        {
            public ControllerInteractionEvent OnButtonTwoPressed = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnButtonTwoReleased = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnButtonTwoTouchStart = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnButtonTwoTouchEnd = new ControllerInteractionEvent();
        }


        [System.Serializable]
        public class StartMenuInput
        {
            public ControllerInteractionEvent OnStartMenuPressed = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnStartMenuReleased = new ControllerInteractionEvent();
        }

        [System.Serializable]
        public class OnAliasInput
        {
            public ControllerInteractionEvent OnAliasPointerOn = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnAliasPointerOff = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnAliasPointerSet = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnAliasGrabOn = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnAliasGrabOff = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnAliasUseOn = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnAliasUseOff = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnAliasUIClickOn = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnAliasUIClickOff = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnAliasMenuOn = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnAliasMenuOff = new ControllerInteractionEvent();
        }

        [System.Serializable]
        public class ControllerEvents
        {
            public ControllerInteractionEvent OnControllerEnabled = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnControllerDisabled = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnControllerIndexChanged = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnControllerModelAvailable = new ControllerInteractionEvent();

            public ControllerInteractionEvent OnControllerVisible = new ControllerInteractionEvent();
            public ControllerInteractionEvent OnControllerHidden = new ControllerInteractionEvent();
        }


        protected override void AddListeners(VRTK_ControllerEvents component)
        {
            component.TriggerPressed += TriggerPressed;
            component.TriggerReleased += TriggerReleased;
            component.TriggerTouchStart += TriggerTouchStart;
            component.TriggerTouchEnd += TriggerTouchEnd;
            component.TriggerHairlineStart += TriggerHairlineStart;
            component.TriggerHairlineEnd += TriggerHairlineEnd;
            component.TriggerClicked += TriggerClicked;
            component.TriggerUnclicked += TriggerUnclicked;
            component.TriggerAxisChanged += TriggerAxisChanged;

            component.GripPressed += GripPressed;
            component.GripReleased += GripReleased;
            component.GripTouchStart += GripTouchStart;
            component.GripTouchEnd += GripTouchEnd;
            component.GripHairlineStart += GripHairlineStart;
            component.GripHairlineEnd += GripHairlineEnd;
            component.GripClicked += GripClicked;
            component.GripUnclicked += GripUnclicked;
            component.GripAxisChanged += GripAxisChanged;

            component.TouchpadPressed += TouchpadPressed;
            component.TouchpadReleased += TouchpadReleased;
            component.TouchpadTouchStart += TouchpadTouchStart;
            component.TouchpadTouchEnd += TouchpadTouchEnd;
            component.TouchpadAxisChanged += TouchpadAxisChanged;

            component.ButtonOnePressed += ButtonOnePressed;
            component.ButtonOneReleased += ButtonOneReleased;
            component.ButtonOneTouchStart += ButtonOneTouchStart;
            component.ButtonOneTouchEnd += ButtonOneTouchEnd;

            component.ButtonTwoPressed += ButtonTwoPressed;
            component.ButtonTwoReleased += ButtonTwoReleased;
            component.ButtonTwoTouchStart += ButtonTwoTouchStart;
            component.ButtonTwoTouchEnd += ButtonTwoTouchEnd;

            component.StartMenuPressed += StartMenuPressed;
            component.StartMenuReleased += StartMenuReleased;

            component.ControllerEnabled += ControllerEnabled;
            component.ControllerDisabled += ControllerDisabled;
            component.ControllerIndexChanged += ControllerIndexChanged;
            component.ControllerModelAvailable += ControllerModelAvailable;

            component.ControllerVisible += ControllerVisible;
            component.ControllerHidden += ControllerHidden;
        }

        protected override void RemoveListeners(VRTK_ControllerEvents component)
        {
            component.TriggerPressed -= TriggerPressed;
            component.TriggerReleased -= TriggerReleased;
            component.TriggerTouchStart -= TriggerTouchStart;
            component.TriggerTouchEnd -= TriggerTouchEnd;
            component.TriggerHairlineStart -= TriggerHairlineStart;
            component.TriggerHairlineEnd -= TriggerHairlineEnd;
            component.TriggerClicked -= TriggerClicked;
            component.TriggerUnclicked -= TriggerUnclicked;
            component.TriggerAxisChanged -= TriggerAxisChanged;

            component.GripPressed -= GripPressed;
            component.GripReleased -= GripReleased;
            component.GripTouchStart -= GripTouchStart;
            component.GripTouchEnd -= GripTouchEnd;
            component.GripHairlineStart -= GripHairlineStart;
            component.GripHairlineEnd -= GripHairlineEnd;
            component.GripClicked -= GripClicked;
            component.GripUnclicked -= GripUnclicked;
            component.GripAxisChanged -= GripAxisChanged;

            component.TouchpadPressed -= TouchpadPressed;
            component.TouchpadReleased -= TouchpadReleased;
            component.TouchpadTouchStart -= TouchpadTouchStart;
            component.TouchpadTouchEnd -= TouchpadTouchEnd;
            component.TouchpadAxisChanged -= TouchpadAxisChanged;

            component.ButtonOnePressed -= ButtonOnePressed;
            component.ButtonOneReleased -= ButtonOneReleased;
            component.ButtonOneTouchStart -= ButtonOneTouchStart;
            component.ButtonOneTouchEnd -= ButtonOneTouchEnd;

            component.ButtonTwoPressed -= ButtonTwoPressed;
            component.ButtonTwoReleased -= ButtonTwoReleased;
            component.ButtonTwoTouchStart -= ButtonTwoTouchStart;
            component.ButtonTwoTouchEnd -= ButtonTwoTouchEnd;

            component.StartMenuPressed -= StartMenuPressed;
            component.StartMenuReleased -= StartMenuReleased;

            component.ControllerEnabled -= ControllerEnabled;
            component.ControllerDisabled -= ControllerDisabled;
            component.ControllerIndexChanged -= ControllerIndexChanged;
            component.ControllerModelAvailable -= ControllerModelAvailable;

            component.ControllerVisible -= ControllerVisible;
            component.ControllerHidden -= ControllerHidden;
        }

        #region TRIGGER INPUT
        private void TriggerPressed(object o, ControllerInteractionEventArgs e)
        {
            trigger.OnTriggerPressed.Invoke(o, e);
        }

        private void TriggerReleased(object o, ControllerInteractionEventArgs e)
        {
            trigger.OnTriggerReleased.Invoke(o, e);
        }

        private void TriggerTouchStart(object o, ControllerInteractionEventArgs e)
        {
            trigger.OnTriggerTouchStart.Invoke(o, e);
        }

        private void TriggerTouchEnd(object o, ControllerInteractionEventArgs e)
        {
            trigger.OnTriggerTouchEnd.Invoke(o, e);
        }

        private void TriggerHairlineStart(object o, ControllerInteractionEventArgs e)
        {
            trigger.OnTriggerHairlineStart.Invoke(o, e);
        }

        private void TriggerHairlineEnd(object o, ControllerInteractionEventArgs e)
        {
            trigger.OnTriggerHairlineEnd.Invoke(o, e);
        }

        private void TriggerClicked(object o, ControllerInteractionEventArgs e)
        {
            trigger.OnTriggerClicked.Invoke(o, e);
        }

        private void TriggerUnclicked(object o, ControllerInteractionEventArgs e)
        {
            trigger.OnTriggerUnclicked.Invoke(o, e);
        }

        private void TriggerAxisChanged(object o, ControllerInteractionEventArgs e)
        {
            trigger.OnTriggerAxisChanged.Invoke(o, e);
        }
        #endregion //TRIGGER INPUT

        #region GRIP INPUT
        private void GripPressed(object o, ControllerInteractionEventArgs e)
        {
            grip.OnGripPressed.Invoke(o, e);
        }

        private void GripReleased(object o, ControllerInteractionEventArgs e)
        {
            grip.OnGripReleased.Invoke(o, e);
        }

        private void GripTouchStart(object o, ControllerInteractionEventArgs e)
        {
            grip.OnGripTouchStart.Invoke(o, e);
        }

        private void GripTouchEnd(object o, ControllerInteractionEventArgs e)
        {
            grip.OnGripTouchEnd.Invoke(o, e);
        }

        private void GripHairlineStart(object o, ControllerInteractionEventArgs e)
        {
            grip.OnGripHairlineStart.Invoke(o, e);
        }

        private void GripHairlineEnd(object o, ControllerInteractionEventArgs e)
        {
            grip.OnGripHairlineEnd.Invoke(o, e);
        }

        private void GripClicked(object o, ControllerInteractionEventArgs e)
        {
            grip.OnGripClicked.Invoke(o, e);
        }

        private void GripUnclicked(object o, ControllerInteractionEventArgs e)
        {
            grip.OnGripUnclicked.Invoke(o, e);
        }

        private void GripAxisChanged(object o, ControllerInteractionEventArgs e)
        {
            grip.OnGripAxisChanged.Invoke(o, e);
        }
        #endregion //GRIP INPUT

        #region TOUCPHAD INPUT
        private void TouchpadPressed(object o, ControllerInteractionEventArgs e)
        {
            touchpad.OnTouchpadPressed.Invoke(o, e);
        }

        private void TouchpadReleased(object o, ControllerInteractionEventArgs e)
        {
            touchpad.OnTouchpadReleased.Invoke(o, e);
        }

        private void TouchpadTouchStart(object o, ControllerInteractionEventArgs e)
        {
            touchpad.OnTouchpadTouchStart.Invoke(o, e);
        }

        private void TouchpadTouchEnd(object o, ControllerInteractionEventArgs e)
        {
            touchpad.OnTouchpadTouchEnd.Invoke(o, e);
        }

        private void TouchpadAxisChanged(object o, ControllerInteractionEventArgs e)
        {
            touchpad.OnTouchpadAxisChanged.Invoke(o, e);
        }
        #endregion //TOUCHPAD INPUT

        #region BUTTON ONE INPUT
        private void ButtonOnePressed(object o, ControllerInteractionEventArgs e)
        {
            buttonOne.OnButtonOnePressed.Invoke(o, e);
        }

        private void ButtonOneReleased(object o, ControllerInteractionEventArgs e)
        {
            buttonOne.OnButtonOneReleased.Invoke(o, e);
        }

        private void ButtonOneTouchStart(object o, ControllerInteractionEventArgs e)
        {
            buttonOne.OnButtonOneTouchStart.Invoke(o, e);
        }

        private void ButtonOneTouchEnd(object o, ControllerInteractionEventArgs e)
        {
            buttonOne.OnButtonOneTouchEnd.Invoke(o, e);
        }
        #endregion //BUTTON ONE INPUT

        #region BUTTON TWO INPUT
        private void ButtonTwoPressed(object o, ControllerInteractionEventArgs e)
        {
            buttonTwo.OnButtonTwoPressed.Invoke(o, e);
        }

        private void ButtonTwoReleased(object o, ControllerInteractionEventArgs e)
        {
            buttonTwo.OnButtonTwoReleased.Invoke(o, e);
        }

        private void ButtonTwoTouchStart(object o, ControllerInteractionEventArgs e)
        {
            buttonTwo.OnButtonTwoTouchStart.Invoke(o, e);
        }

        private void ButtonTwoTouchEnd(object o, ControllerInteractionEventArgs e)
        {
            buttonTwo.OnButtonTwoTouchEnd.Invoke(o, e);
        }
        #endregion //BUTTON TWO INPUT

        #region START MENU INPUT
        private void StartMenuPressed(object o, ControllerInteractionEventArgs e)
        {
            startMenu.OnStartMenuPressed.Invoke(o, e);
        }

        private void StartMenuReleased(object o, ControllerInteractionEventArgs e)
        {
            startMenu.OnStartMenuReleased.Invoke(o, e);
        }
        #endregion //START MENU INPUT

        #region ALIAS INPUT
        private void AliasPointerOn(object o, ControllerInteractionEventArgs e)
        {
            onAlias.OnAliasPointerOn.Invoke(o, e);
        }

        private void AliasPointerOff(object o, ControllerInteractionEventArgs e)
        {
            onAlias.OnAliasPointerOff.Invoke(o, e);
        }

        private void AliasPointerSet(object o, ControllerInteractionEventArgs e)
        {
            onAlias.OnAliasPointerSet.Invoke(o, e);
        }

        private void AliasGrabOn(object o, ControllerInteractionEventArgs e)
        {
            onAlias.OnAliasGrabOn.Invoke(o, e);
        }

        private void AliasGrabOff(object o, ControllerInteractionEventArgs e)
        {
            onAlias.OnAliasGrabOff.Invoke(o, e);
        }

        private void AliasUseOn(object o, ControllerInteractionEventArgs e)
        {
            onAlias.OnAliasUseOn.Invoke(o, e);
        }

        private void AliasUseOff(object o, ControllerInteractionEventArgs e)
        {
            onAlias.OnAliasUseOff.Invoke(o, e);
        }

        private void AliasUIClickOn(object o, ControllerInteractionEventArgs e)
        {
            onAlias.OnAliasUIClickOn.Invoke(o, e);
        }

        private void AliasUIClickOff(object o, ControllerInteractionEventArgs e)
        {
            onAlias.OnAliasUIClickOff.Invoke(o, e);
        }

        private void AliasMenuOn(object o, ControllerInteractionEventArgs e)
        {
            onAlias.OnAliasMenuOn.Invoke(o, e);
        }

        private void AliasMenuOff(object o, ControllerInteractionEventArgs e)
        {
            onAlias.OnAliasMenuOff.Invoke(o, e);
        }
        #endregion //ALIAS INPUT

        #region CONTROLLER EVENTS
        private void ControllerEnabled(object o, ControllerInteractionEventArgs e)
        {
            controllerEvents.OnControllerEnabled.Invoke(o, e);
        }

        private void ControllerDisabled(object o, ControllerInteractionEventArgs e)
        {
            controllerEvents.OnControllerDisabled.Invoke(o, e);
        }

        private void ControllerIndexChanged(object o, ControllerInteractionEventArgs e)
        {
            controllerEvents.OnControllerIndexChanged.Invoke(o, e);
        }

        private void ControllerModelAvailable(object o, ControllerInteractionEventArgs e)
        {
            controllerEvents.OnControllerModelAvailable.Invoke(o, e);
        }

        private void ControllerVisible(object o, ControllerInteractionEventArgs e)
        {
            controllerEvents.OnControllerVisible.Invoke(o, e);
        }

        private void ControllerHidden(object o, ControllerInteractionEventArgs e)
        {
            controllerEvents.OnControllerHidden.Invoke(o, e);
        }
        #endregion //CONTROLLER EVENTS
    }
}
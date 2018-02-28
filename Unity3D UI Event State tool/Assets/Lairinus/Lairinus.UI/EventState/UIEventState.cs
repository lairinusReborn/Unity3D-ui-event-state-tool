﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Lairinus.UI
{
    [RequireComponent(typeof(Graphic))]
    public class UIEventState : MonoBehaviour, IPointerClickHandler, IPointerUpHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IInitializePotentialDragHandler
    {
        #region Remarks

        /*
         *   This component captures every pointer event and then:
         *     1. Changes the UI Graphic's color
         *     2. Changes the UI Graphic's sprite (if applicable)
         *     3. Calls methods attached to any GameObjects in the scene, or on other objects not in the scene
         *   Limitations:
         *      1. Can only be used on "UnityEngine.UI.Graphic" objects such as Images and Texts.
         *      2. The property "raycastTarget" MUST be set to true. If there are no raycasts, there are no events
         */

        #endregion Remarks

        [SerializeField] private bool _enableDebugging = false;
        [SerializeField] private EventState _onPointerClick = new EventState();
        [SerializeField] private EventState _onPointerDown = new EventState();
        [SerializeField] private EventState _onPointerUp = new EventState();
        [SerializeField] private EventState _onPointerEnter = new EventState();
        [SerializeField] private EventState _onPointerExit = new EventState();
        [SerializeField] private EventState _onBeginDrag = new EventState();
        [SerializeField] private EventState _onEndDrag = new EventState();
        [SerializeField] private EventState _onDrag = new EventState();
        [SerializeField] private EventState _onIntiializePotentialDrag = new EventState();

        public void OnBeginDrag(PointerEventData eventData)
        {
            #region Remarks

            /*
             *   Called the moment the user drags the mouse with left or right click held down
             */

            #endregion Remarks

            if (_enableDebugging)
                Debug.Log(Debugger.Debug_OnBeginDrag.Replace("%%custom%%", name));
        }

        public void OnDrag(PointerEventData eventData)
        {
            #region Remarks

            /*
             *   Called while the user is pressing the left or the mouse button down while moving their mouse
             */

            #endregion Remarks

            if (_enableDebugging)
                Debug.Log(Debugger.Debug_OnDrag.Replace("%%custom%%", name));
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            #region Remarks

            /*
             *   Called the moment after the user lets up on their mouse after dragging
             */

            #endregion Remarks

            if (_enableDebugging)
                Debug.Log(Debugger.Debug_OnEndDrag.Replace("%%custom%%", name));
        }

        public void OnInitializePotentialDrag(PointerEventData eventData)
        {
            #region Remarks

            /*
             *   Similar to OnPointerDown. Called when the left or right mouse button is pressed down. Called after the OnPointerDown event
             */

            #endregion Remarks

            if (_enableDebugging)
                Debug.Log(Debugger.Debug_OnPotentialDragInitialized.Replace("%%custom%%", name));
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            #region Remarks

            /*
             *   Called after OnPointerUp. Very similar to OnPointerUp
             */

            #endregion Remarks

            if (_enableDebugging)
                Debug.Log(Debugger.Debug_OnPointerClick.Replace("%%custom%%", name));
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            if (_enableDebugging)
                Debug.Log(Debugger.Debug_OnPointerDown.Replace("%%custom%%", name));
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            if (_enableDebugging)
                Debug.Log(Debugger.Debug_OnPointerDown.Replace("%%custom%%", name));
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            if (_enableDebugging)
                Debug.Log(Debugger.Debug_OnPointerExit.Replace("%%custom%%", name));
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            if (_enableDebugging)
                Debug.Log(Debugger.Debug_OnPointerUp.Replace("%%custom%%", name));
        }

        [System.Serializable]
        public class EventState
        {
            [SerializeField] private bool _stateEnabled = true;
            [SerializeField] private Sprite _sprite = null;
            [SerializeField] private Color _color = new Color();
        }

        private class Debugger
        {
            #region Remarks

            /*
             *   Provides the user with useful information
             */

            #endregion Remarks

            public static readonly string Debug_OnPointerDown = "UIEventState on GameObject %%custom%% => Registered POINTER DOWN";
            public static readonly string Debug_OnPointerUp = "UIEventState on GameObject %%custom%% => Registered POINTER UP";
            public static readonly string Debug_OnPointerClick = "UIEventState on GameObject %%custom%% => Registered POINTER CLICK";
            public static readonly string Debug_OnPointerEnter = "UIEventState on GameObject %%custom%% => Registered POINTER ENTER";
            public static readonly string Debug_OnPointerExit = "UIEventState on GameObject %%custom%% => Registered POINTER EXIT";
            public static readonly string Debug_OnBeginDrag = "UIEventState on GameObject %%custom%% => Registered BEGIN DRAG";
            public static readonly string Debug_OnEndDrag = "UIEventState on GameObject %%custom%% => Registered END DRAG";
            public static readonly string Debug_OnDrag = "UIEventState on GameObject %%custom%% => Registered DRAG";
            public static readonly string Debug_OnPotentialDragInitialized = "UIEventState on GameObject %%custom%% => Registered POTENTIAL DRAG INITIALIZED";
        }
    }
}
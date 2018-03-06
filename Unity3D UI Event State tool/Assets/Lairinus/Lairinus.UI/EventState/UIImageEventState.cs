﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Lairinus.UI.Events
{
    #region Remarks

    /*
     *   External and internal use
     *   ------------------
     *   Contains pointer events that call events that can be used with a UnityEngine.UI.Image object.
     */

    #endregion Remarks

    [ExecuteInEditMode]
    [RequireComponent(typeof(RectTransform))]
    [RequireComponent(typeof(Image))]
    public class UIImageEventState : UIEventState
    {
        #region Remarks

        /*
         *   External and internal use
         *   ------------------
         *   Contains pointer events that call events that can be used with an image object.
         */

        #endregion Remarks

        #region Protected Methods

        protected override void Awake()
        {
            #region Remarks

            /*
             *   Internal use only
             *   ------------------
             *   The same as a "new Class()" constructor in non-MonoBehaviours
             */

            #endregion Remarks

            base.Awake();
            graphicElement = GetComponent<Image>();
            onBeginDragState = _onBeginDragState;
            onDragState = _onDragState;
            onEndDragState = _onEndDragState;
            onHoverState = _onHoverState;
            onNormalState = _onNormalState;
            onPointerClickState = _onPointerClickState;
            onPointerDownState = _onPointerDownState;
            onPointerEnterState = _onPointerEnterState;
            onPointerExitState = _onPointerExitState;
            onPointerUpState = _onPointerUpState;

            // Add all of the event states to a Dictionary for easy access
            eventStatesCollection = new Dictionary<EventType, EventState>();
            eventStatesCollection.Add(onHoverState.eventType, onHoverState);
            eventStatesCollection.Add(onNormalState.eventType, onNormalState);
            eventStatesCollection.Add(onPointerEnterState.eventType, onPointerEnterState);
            eventStatesCollection.Add(onPointerExitState.eventType, onPointerExitState);
            eventStatesCollection.Add(onPointerDownState.eventType, onPointerDownState);
            eventStatesCollection.Add(onPointerUpState.eventType, onPointerUpState);
            eventStatesCollection.Add(onPointerClickState.eventType, onPointerClickState);
            eventStatesCollection.Add(onBeginDragState.eventType, onBeginDragState);
            eventStatesCollection.Add(onEndDragState.eventType, onEndDragState);
            eventStatesCollection.Add(onDragState.eventType, onDragState);
        }

        #endregion Protected Methods

        #region Private Fields

        [SerializeField] private ImageEventState _onBeginDragState = new ImageEventState(EventType.OnBeginDrag);
        [SerializeField] private ImageEventState _onDragState = new ImageEventState(EventType.OnDrag);
        [SerializeField] private ImageEventState _onEndDragState = new ImageEventState(EventType.OnEndDrag);
        [SerializeField] private ImageEventState _onHoverState = new ImageEventState(EventType.OnHover);
        [SerializeField] private ImageEventState _onNormalState = new ImageEventState(EventType.OnNormal);
        [SerializeField] private ImageEventState _onPointerClickState = new ImageEventState(EventType.OnPointerClick);
        [SerializeField] private ImageEventState _onPointerDownState = new ImageEventState(EventType.OnPointerDown);
        [SerializeField] private ImageEventState _onPointerEnterState = new ImageEventState(EventType.OnPointerEnter);
        [SerializeField] private ImageEventState _onPointerExitState = new ImageEventState(EventType.OnPointerExit);
        [SerializeField] private ImageEventState _onPointerUpState = new ImageEventState(EventType.OnPointerUp);

        #endregion Private Fields
    }
}
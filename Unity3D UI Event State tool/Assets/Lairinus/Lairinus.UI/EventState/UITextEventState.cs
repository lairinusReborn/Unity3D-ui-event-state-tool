﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Lairinus.UI.Events
{
    [RequireComponent(typeof(RectTransform))]
    [RequireComponent(typeof(Text))]
    public class UITextEventState : UIEventState
    {
        #region Remarks

        /*
         *   External and internal use
         *   ------------------
         *   Contains pointer events that call events that can be used with a UnityEngine.UI.Text object.
         */

        #endregion Remarks

        [SerializeField] private TextEventState _onBeginDragState = new TextEventState(EventType.OnBeginDrag);
        [SerializeField] private TextEventState _onDragState = new TextEventState(EventType.OnDrag);
        [SerializeField] private TextEventState _onEndDragState = new TextEventState(EventType.OnEndDrag);
        [SerializeField] private TextEventState _onHoverState = new TextEventState(EventType.OnHover);
        [SerializeField] private TextEventState _onNormalState = new TextEventState(EventType.OnNormal);
        [SerializeField] private TextEventState _onPointerClickState = new TextEventState(EventType.OnPointerClick);
        [SerializeField] private TextEventState _onPointerDownState = new TextEventState(EventType.OnPointerDown);
        [SerializeField] private TextEventState _onPointerEnterState = new TextEventState(EventType.OnPointerEnter);
        [SerializeField] private TextEventState _onPointerExitState = new TextEventState(EventType.OnPointerExit);
        [SerializeField] private TextEventState _onPointerUpState = new TextEventState(EventType.OnPointerUp);

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
            graphicElement = GetComponent<Text>();
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
    }
}
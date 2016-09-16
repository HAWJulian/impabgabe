// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace abgabe {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.Kernel;
    using UnityEngine;
    
    
    public class GestureSystemGameReadyHandler {
        
        private uFrame.Kernel.GameReadyEvent _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private ComplexGesture ActionNode17_Result = default( ComplexGesture );
        
        private ComplexGesture ActionNode18_gesture = default( ComplexGesture );
        
        private float ActionNode18_min = default( System.Single );
        
        private float FloatNode19 = 0F;
        
        private float ActionNode18_max = default( System.Single );
        
        private float FloatNode20 = 25F;
        
        private ComplexGesture ActionNode18_Result = default( ComplexGesture );
        
        private ComplexGesture ActionNode21_gesture = default( ComplexGesture );
        
        private bool ActionNode21_triggerLeft = default( System.Boolean );
        
        private bool BoolNode22 = true;
        
        private bool ActionNode21_triggerRight = default( System.Boolean );
        
        private bool BoolNode23 = false;
        
        private abgabe.LeftPinchDetected PublishEventNode24_Result = default( abgabe.LeftPinchDetected );
        
        private ComplexGesture ActionNode25_gesture = default( ComplexGesture );
        
        private bool ActionNode25_triggerLeft = default( System.Boolean );
        
        private bool ActionNode25_triggerRight = default( System.Boolean );
        
        private abgabe.RightPinchDetected PublishEventNode26_Result = default( abgabe.RightPinchDetected );
        
        private bool ActionNode51_thumb = default( System.Boolean );
        
        private bool BoolNode53 = true;
        
        private bool ActionNode51_index = default( System.Boolean );
        
        private bool BoolNode52 = false;
        
        private bool ActionNode51_middle = default( System.Boolean );
        
        private bool ActionNode51_fourth = default( System.Boolean );
        
        private bool ActionNode51_fifth = default( System.Boolean );
        
        private bool ActionNode51_triggerLeft = default( System.Boolean );
        
        private bool ActionNode51_triggerRight = default( System.Boolean );
        
        private abgabe.UnparentMovableObject PublishEventNode54_Result = default( abgabe.UnparentMovableObject );
        
        private bool ActionNode79_thumb = default( System.Boolean );
        
        private bool BoolNode80 = false;
        
        private bool ActionNode79_index = default( System.Boolean );
        
        private bool ActionNode79_middle = default( System.Boolean );
        
        private bool BoolNode81 = true;
        
        private bool ActionNode79_fourth = default( System.Boolean );
        
        private bool ActionNode79_fifth = default( System.Boolean );
        
        private bool ActionNode79_triggerLeft = default( System.Boolean );
        
        private bool ActionNode79_triggerRight = default( System.Boolean );
        
        private abgabe.DeleteObjectEvent PublishEventNode82_Result = default( abgabe.DeleteObjectEvent );
        
        private bool ActionNode91_thumb = default( System.Boolean );
        
        private bool BoolNode92 = false;
        
        private bool ActionNode91_index = default( System.Boolean );
        
        private bool BoolNode93 = true;
        
        private bool ActionNode91_middle = default( System.Boolean );
        
        private bool ActionNode91_fourth = default( System.Boolean );
        
        private bool ActionNode91_fifth = default( System.Boolean );
        
        private bool ActionNode91_triggerLeft = default( System.Boolean );
        
        private bool ActionNode91_triggerRight = default( System.Boolean );
        
        private abgabe.RotateObjectEvent PublishEventNode94_Result = default( abgabe.RotateObjectEvent );
        
        public uFrame.Kernel.GameReadyEvent Event {
            get {
                return _Event;
            }
            set {
                _Event = value;
            }
        }
        
        public uFrame.ECS.EcsSystem System {
            get {
                return _System;
            }
            set {
                _System = value;
            }
        }
        
        public virtual System.Collections.IEnumerator Execute() {
            // ActionNode
            while (this.DebugInfo("5d36b5f4-52a1-49d8-96a8-e3b96a89f30e","e48fb147-f08f-4bf9-80ab-4967c9f6793c", this) == 1) yield return null;
            // Visit ComplexGestureUtils.createComplexGesture
            ActionNode17_Result = ComplexGestureUtils.createComplexGesture();
            ActionNode18_gesture = ActionNode17_Result;
            ActionNode18_min = FloatNode19;
            ActionNode18_max = FloatNode20;
            // ActionNode
            while (this.DebugInfo("e48fb147-f08f-4bf9-80ab-4967c9f6793c","1646f814-7bed-4775-ac12-11bdddcef867", this) == 1) yield return null;
            // Visit ComplexGestureUtils.addComplexPinchDistance
            ActionNode18_Result = ComplexGestureUtils.addComplexPinchDistance(ActionNode18_gesture, ActionNode18_min, ActionNode18_max);
            ActionNode21_gesture = ActionNode18_Result;
            ActionNode21_triggerLeft = BoolNode22;
            ActionNode21_triggerRight = BoolNode23;
            // ActionNode
            while (this.DebugInfo("1646f814-7bed-4775-ac12-11bdddcef867","0c09a698-5e57-4a50-b779-2a4f91a36cf6", this) == 1) yield return null;
            // Visit ComplexGestureUtils.registerUpdatingGesture
            ComplexGestureUtils.registerUpdatingGesture(ActionNode21_gesture, ActionNode21_triggerLeft, ActionNode21_triggerRight, ()=> { System.StartCoroutine(ActionNode21_onDetect()); });
            ActionNode25_gesture = ActionNode18_Result;
            ActionNode25_triggerLeft = BoolNode23;
            ActionNode25_triggerRight = BoolNode22;
            // ActionNode
            while (this.DebugInfo("6b09c43f-8f8a-420b-8a2a-4c4f1d372b7d","a79d9902-d9cb-4dc6-9fcc-05fc6d130cce", this) == 1) yield return null;
            // Visit ComplexGestureUtils.registerUpdatingGesture
            ComplexGestureUtils.registerUpdatingGesture(ActionNode25_gesture, ActionNode25_triggerLeft, ActionNode25_triggerRight, ()=> { System.StartCoroutine(ActionNode25_onDetect()); });
            ActionNode51_thumb = BoolNode53;
            ActionNode51_index = BoolNode52;
            ActionNode51_middle = BoolNode52;
            ActionNode51_fourth = BoolNode52;
            ActionNode51_fifth = BoolNode52;
            ActionNode51_triggerLeft = BoolNode53;
            ActionNode51_triggerRight = BoolNode53;
            // ActionNode
            while (this.DebugInfo("463507e8-b78c-4778-b71c-70aeaf9b89a4","fde509c2-7d65-4236-affc-ac408d3c2584", this) == 1) yield return null;
            // Visit GestureUtils.registerUpdatingGesture
            GestureUtils.registerUpdatingGesture(ActionNode51_thumb, ActionNode51_index, ActionNode51_middle, ActionNode51_fourth, ActionNode51_fifth, ()=> { System.StartCoroutine(ActionNode51_action()); }, ActionNode51_triggerLeft, ActionNode51_triggerRight);
            ActionNode79_thumb = BoolNode80;
            ActionNode79_index = BoolNode80;
            ActionNode79_middle = BoolNode81;
            ActionNode79_fourth = BoolNode80;
            ActionNode79_fifth = BoolNode80;
            ActionNode79_triggerLeft = BoolNode81;
            ActionNode79_triggerRight = BoolNode81;
            // ActionNode
            while (this.DebugInfo("a38df202-1cb4-43da-b60f-f3dda82357c4","55689492-bead-4d5d-8a42-5ff2022fa0bc", this) == 1) yield return null;
            // Visit GestureUtils.registerUpdatingGesture
            GestureUtils.registerUpdatingGesture(ActionNode79_thumb, ActionNode79_index, ActionNode79_middle, ActionNode79_fourth, ActionNode79_fifth, ()=> { System.StartCoroutine(ActionNode79_action()); }, ActionNode79_triggerLeft, ActionNode79_triggerRight);
            ActionNode91_thumb = BoolNode92;
            ActionNode91_index = BoolNode93;
            ActionNode91_middle = BoolNode92;
            ActionNode91_fourth = BoolNode92;
            ActionNode91_fifth = BoolNode93;
            ActionNode91_triggerLeft = BoolNode93;
            ActionNode91_triggerRight = BoolNode93;
            // ActionNode
            while (this.DebugInfo("a1b47804-2d91-4f68-9628-6d3015d92c53","ec746d50-7dc2-4e13-9f0f-8cb2ab75a555", this) == 1) yield return null;
            // Visit GestureUtils.registerUpdatingGesture
            GestureUtils.registerUpdatingGesture(ActionNode91_thumb, ActionNode91_index, ActionNode91_middle, ActionNode91_fourth, ActionNode91_fifth, ()=> { System.StartCoroutine(ActionNode91_action()); }, ActionNode91_triggerLeft, ActionNode91_triggerRight);
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode21_onDetect() {
            // PublishEventNode
            while (this.DebugInfo("0c09a698-5e57-4a50-b779-2a4f91a36cf6","6b09c43f-8f8a-420b-8a2a-4c4f1d372b7d", this) == 1) yield return null;
            var PublishEventNode24_Event = new LeftPinchDetected();
            System.Publish(PublishEventNode24_Event);
            PublishEventNode24_Result = PublishEventNode24_Event;
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode25_onDetect() {
            // PublishEventNode
            while (this.DebugInfo("a79d9902-d9cb-4dc6-9fcc-05fc6d130cce","463507e8-b78c-4778-b71c-70aeaf9b89a4", this) == 1) yield return null;
            var PublishEventNode26_Event = new RightPinchDetected();
            System.Publish(PublishEventNode26_Event);
            PublishEventNode26_Result = PublishEventNode26_Event;
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode51_action() {
            // PublishEventNode
            while (this.DebugInfo("fde509c2-7d65-4236-affc-ac408d3c2584","a38df202-1cb4-43da-b60f-f3dda82357c4", this) == 1) yield return null;
            var PublishEventNode54_Event = new UnparentMovableObject();
            System.Publish(PublishEventNode54_Event);
            PublishEventNode54_Result = PublishEventNode54_Event;
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode79_action() {
            // PublishEventNode
            while (this.DebugInfo("55689492-bead-4d5d-8a42-5ff2022fa0bc","a1b47804-2d91-4f68-9628-6d3015d92c53", this) == 1) yield return null;
            var PublishEventNode82_Event = new DeleteObjectEvent();
            System.Publish(PublishEventNode82_Event);
            PublishEventNode82_Result = PublishEventNode82_Event;
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode91_action() {
            // PublishEventNode
            while (this.DebugInfo("ec746d50-7dc2-4e13-9f0f-8cb2ab75a555","914ef933-cb2a-46d4-9ef7-6298dc7d7943", this) == 1) yield return null;
            var PublishEventNode94_Event = new RotateObjectEvent();
            System.Publish(PublishEventNode94_Event);
            PublishEventNode94_Result = PublishEventNode94_Event;
            yield break;
        }
    }
}

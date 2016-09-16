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
    using Leap;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.Kernel;
    using UnityEngine;
    
    
    public class GestureSystemUpdateHandler {
        
        private uFrame.ECS.ISystemUpdate _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private object ActionNode125_message = default( System.Object );
        
        private Leap.Frame ActionNode101_Result = default( Leap.Frame );
        
        private Leap.Frame ActionNode102_frame = default( Leap.Frame );
        
        private Leap.Hand ActionNode102_left = default( Leap.Hand );
        
        private object ActionNode103_toCheck = default( System.Object );
        
        private object ActionNode104_key = default( System.Object );
        
        private int IntNode109 = 0;
        
        private Leap.Hand ActionNode104_hand = default( Leap.Hand );
        
        private bool ActionNode114_value = default( System.Boolean );
        
        private abgabe.RotateObjectEvent PublishEventNode115_Result = default( abgabe.RotateObjectEvent );
        
        private bool BoolNode119 = true;
        
        private bool BoolNode117 = false;
        
        private Leap.Frame ActionNode110_Result = default( Leap.Frame );
        
        private Leap.Frame ActionNode111_frame = default( Leap.Frame );
        
        private Leap.Hand ActionNode111_right = default( Leap.Hand );
        
        private object ActionNode112_toCheck = default( System.Object );
        
        private object ActionNode113_key = default( System.Object );
        
        private Leap.Hand ActionNode113_hand = default( Leap.Hand );
        
        private bool ActionNode120_value = default( System.Boolean );
        
        private abgabe.RotateObjectEvent PublishEventNode121_Result = default( abgabe.RotateObjectEvent );
        
        private bool BoolNode124 = false;
        
        public uFrame.ECS.ISystemUpdate Event {
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
            ActionNode125_message = GestureSystem.Instance.rotateTrigger2;
            // ActionNode
            while (this.DebugInfo("","602b599f-efbe-4d60-85a9-e86a09037890", this) == 1) yield return null;
            // Visit uFrame.Actions.DebugLibrary.LogMessage
            uFrame.Actions.DebugLibrary.LogMessage(ActionNode125_message);
            // ActionNode
            while (this.DebugInfo("602b599f-efbe-4d60-85a9-e86a09037890","acc5af3b-0ffa-4ecf-ba99-4d17c503546d", this) == 1) yield return null;
            // Visit FrameUtils.getFrame
            ActionNode101_Result = FrameUtils.getFrame();
            ActionNode102_frame = ActionNode101_Result;
            // ActionNode
            while (this.DebugInfo("acc5af3b-0ffa-4ecf-ba99-4d17c503546d","3ab807d3-063d-4e4f-9a57-ddeed16ba70f", this) == 1) yield return null;
            // Visit FrameUtils.getLeftHandFromFrame
            FrameUtils.getLeftHandFromFrame(ActionNode102_frame, out ActionNode102_left);
            ActionNode103_toCheck = ActionNode102_left;
            // ActionNode
            while (this.DebugInfo("3ab807d3-063d-4e4f-9a57-ddeed16ba70f","135d6dfb-fab2-4ef4-8308-ea89d3b2c757", this) == 1) yield return null;
            // Visit ConditionsUtils.isNull
            ConditionsUtils.isNull(ActionNode103_toCheck, ()=> { System.StartCoroutine(ActionNode103_yes()); }, ()=> { System.StartCoroutine(ActionNode103_no()); });
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode103_yes() {
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode114_yes() {
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode114_no() {
            // PublishEventNode
            while (this.DebugInfo("8870bad7-994d-47b5-bd09-008f1470ef74","75c90d61-2407-48a4-b28e-9bc6d27e361d", this) == 1) yield return null;
            var PublishEventNode115_Event = new RotateObjectEvent();
            System.Publish(PublishEventNode115_Event);
            PublishEventNode115_Result = PublishEventNode115_Event;
            // SetVariableNode
            while (this.DebugInfo("75c90d61-2407-48a4-b28e-9bc6d27e361d","5e71aa10-0888-4ddd-a41f-9c14d7ad0f9c", this) == 1) yield return null;
            GestureSystem.Instance.rotateTrigger = (System.Boolean)BoolNode119;
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode104_yes() {
            ActionNode114_value = GestureSystem.Instance.rotateTrigger;
            // ActionNode
            while (this.DebugInfo("81e7a908-ce0c-455f-87c4-16346ea5e0cc","8870bad7-994d-47b5-bd09-008f1470ef74", this) == 1) yield return null;
            // Visit uFrame.Actions.Comparisons.IsTrue
            uFrame.Actions.Comparisons.IsTrue(ActionNode114_value, ()=> { System.StartCoroutine(ActionNode114_yes()); }, ()=> { System.StartCoroutine(ActionNode114_no()); });
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode104_no() {
            // SetVariableNode
            while (this.DebugInfo("5e71aa10-0888-4ddd-a41f-9c14d7ad0f9c","d7e6e6e7-baba-42ad-a906-6e3dcc6abd16", this) == 1) yield return null;
            GestureSystem.Instance.rotateTrigger = (System.Boolean)BoolNode117;
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode112_yes() {
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode120_yes() {
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode120_no() {
            // PublishEventNode
            while (this.DebugInfo("e835f79c-d16f-470b-9d94-174e0e601a39","a107fa3b-b767-404b-bac8-669785ce72d3", this) == 1) yield return null;
            var PublishEventNode121_Event = new RotateObjectEvent();
            System.Publish(PublishEventNode121_Event);
            PublishEventNode121_Result = PublishEventNode121_Event;
            // SetVariableNode
            while (this.DebugInfo("a107fa3b-b767-404b-bac8-669785ce72d3","bee1beee-5054-428f-8a3d-c1211d4360d1", this) == 1) yield return null;
            GestureSystem.Instance.rotateTrigger2 = (System.Boolean)BoolNode119;
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode113_yes() {
            ActionNode120_value = GestureSystem.Instance.rotateTrigger2;
            // ActionNode
            while (this.DebugInfo("e233dc5a-28a6-4901-9983-04467f1eaddc","e835f79c-d16f-470b-9d94-174e0e601a39", this) == 1) yield return null;
            // Visit uFrame.Actions.Comparisons.IsTrue
            uFrame.Actions.Comparisons.IsTrue(ActionNode120_value, ()=> { System.StartCoroutine(ActionNode120_yes()); }, ()=> { System.StartCoroutine(ActionNode120_no()); });
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode113_no() {
            // SetVariableNode
            while (this.DebugInfo("bee1beee-5054-428f-8a3d-c1211d4360d1","c6860e7b-35d9-4d2e-ae20-8161109d226d", this) == 1) yield return null;
            GestureSystem.Instance.rotateTrigger2 = (System.Boolean)BoolNode124;
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode112_no() {
            ActionNode113_key = IntNode109;
            ActionNode113_hand = ActionNode111_right;
            // ActionNode
            while (this.DebugInfo("a3beb5dc-606d-4c8e-af6b-fb7ddcf95c05","e233dc5a-28a6-4901-9983-04467f1eaddc", this) == 1) yield return null;
            // Visit GestureUtils.isGestureSatisified
            GestureUtils.isGestureSatisified(ActionNode113_key, ActionNode113_hand, ()=> { System.StartCoroutine(ActionNode113_yes()); }, ()=> { System.StartCoroutine(ActionNode113_no()); });
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode103_no() {
            ActionNode104_key = IntNode109;
            ActionNode104_hand = ActionNode102_left;
            // ActionNode
            while (this.DebugInfo("135d6dfb-fab2-4ef4-8308-ea89d3b2c757","81e7a908-ce0c-455f-87c4-16346ea5e0cc", this) == 1) yield return null;
            // Visit GestureUtils.isGestureSatisified
            GestureUtils.isGestureSatisified(ActionNode104_key, ActionNode104_hand, ()=> { System.StartCoroutine(ActionNode104_yes()); }, ()=> { System.StartCoroutine(ActionNode104_no()); });
            // ActionNode
            while (this.DebugInfo("d7e6e6e7-baba-42ad-a906-6e3dcc6abd16","74d6e74c-233f-48fa-b8ac-38ecfcdd157a", this) == 1) yield return null;
            // Visit FrameUtils.getFrame
            ActionNode110_Result = FrameUtils.getFrame();
            ActionNode111_frame = ActionNode110_Result;
            // ActionNode
            while (this.DebugInfo("74d6e74c-233f-48fa-b8ac-38ecfcdd157a","20405e55-fc71-4abd-a5d5-e4fe3f5eac5a", this) == 1) yield return null;
            // Visit FrameUtils.getRightHandFromFrame
            FrameUtils.getRightHandFromFrame(ActionNode111_frame, out ActionNode111_right);
            ActionNode112_toCheck = ActionNode111_right;
            // ActionNode
            while (this.DebugInfo("20405e55-fc71-4abd-a5d5-e4fe3f5eac5a","a3beb5dc-606d-4c8e-af6b-fb7ddcf95c05", this) == 1) yield return null;
            // Visit ConditionsUtils.isNull
            ConditionsUtils.isNull(ActionNode112_toCheck, ()=> { System.StartCoroutine(ActionNode112_yes()); }, ()=> { System.StartCoroutine(ActionNode112_no()); });
            yield break;
        }
    }
}
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
    
    
    public class ModifyObjectSystemOnTriggerEnterHandler {
        
        public MenuSelectionComponent Collider;
        
        public MovableObject Source;
        
        private uFrame.ECS.OnTriggerEnterDispatcher _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private object ActionNode75_message = default( System.Object );
        
        private bool ActionNode73_value = default( System.Boolean );
        
        private bool BoolNode78 = false;
        
        public uFrame.ECS.OnTriggerEnterDispatcher Event {
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
            ActionNode75_message = Source.isPlaced;
            // ActionNode
            while (this.DebugInfo("f829ea27-ef81-443d-8b94-f6a2046013dc","f0e6cc04-699e-45ec-8992-cb53f9437d15", this) == 1) yield return null;
            // Visit uFrame.Actions.DebugLibrary.LogMessage
            uFrame.Actions.DebugLibrary.LogMessage(ActionNode75_message);
            ActionNode73_value = Source.isPlaced;
            // ActionNode
            while (this.DebugInfo("f0e6cc04-699e-45ec-8992-cb53f9437d15","3713dc7e-14dc-4417-b8f1-2d307ed5edbe", this) == 1) yield return null;
            // Visit uFrame.Actions.Comparisons.IsTrue
            uFrame.Actions.Comparisons.IsTrue(ActionNode73_value, ()=> { System.StartCoroutine(ActionNode73_yes()); }, ()=> { System.StartCoroutine(ActionNode73_no()); });
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode73_yes() {
            // SetVariableNode
            while (this.DebugInfo("3713dc7e-14dc-4417-b8f1-2d307ed5edbe","19d14b33-fdbb-4058-a54b-da147f97a7f1", this) == 1) yield return null;
            Source.transform.parent = (UnityEngine.Transform)Collider.transform;
            // SetVariableNode
            while (this.DebugInfo("19d14b33-fdbb-4058-a54b-da147f97a7f1","f4b04439-6849-4306-ad19-f50f3d8be328", this) == 1) yield return null;
            Source.isPlaced = (System.Boolean)BoolNode78;
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode73_no() {
            yield break;
        }
    }
}

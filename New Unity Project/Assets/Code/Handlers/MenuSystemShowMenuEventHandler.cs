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
    
    
    public class MenuSystemShowMenuEventHandler {
        
        public MenuComponent Group;
        
        private abgabe.ShowMenuEvent _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private UnityEngine.GameObject ActionNode32_obj = default( UnityEngine.GameObject );
        
        private bool ActionNode32_state = default( System.Boolean );
        
        private bool BoolNode33 = true;
        
        public abgabe.ShowMenuEvent Event {
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
            ActionNode32_obj = Group.gameObject;
            ActionNode32_state = BoolNode33;
            // ActionNode
            while (this.DebugInfo("13b421ac-b8bb-421b-8bbc-7288bbae28dd","f829ea27-ef81-443d-8b94-f6a2046013dc", this) == 1) yield return null;
            // Visit GameObjectUtils.setActive
            GameObjectUtils.setActive(ActionNode32_obj, ActionNode32_state);
            yield break;
        }
    }
}

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
    
    
    public class GestureSystemUnparentMovableObjectHandler {
        
        public MovableObject Group;
        
        private abgabe.UnparentMovableObject _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private object NullNode57;
        
        public abgabe.UnparentMovableObject Event {
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
            // SetVariableNode
            while (this.DebugInfo("","e8db2df5-4b74-4d34-bee2-9720e9cec588", this) == 1) yield return null;
            Group.gameObject.transform.parent = (UnityEngine.Transform)NullNode57;
            yield break;
        }
    }
}

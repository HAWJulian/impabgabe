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
    
    
    public class GestureSystemLeftPinchDetectedHandler {
        
        private abgabe.LeftPinchDetected _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private abgabe.ShowMenuEvent PublishEventNode30_Result = default( abgabe.ShowMenuEvent );
        
        public abgabe.LeftPinchDetected Event {
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
            // PublishEventNode
            while (this.DebugInfo("1f9dbb58-bffb-450a-8889-ee2a86902655","4f45b5ac-09c1-4f14-b981-bf08e9584c7d", this) == 1) yield return null;
            var PublishEventNode30_Event = new ShowMenuEvent();
            System.Publish(PublishEventNode30_Event);
            PublishEventNode30_Result = PublishEventNode30_Event;
            yield break;
        }
    }
}

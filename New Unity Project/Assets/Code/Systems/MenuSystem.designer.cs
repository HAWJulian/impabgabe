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
    using abgabe;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using uFrame.Kernel;
    using UniRx;
    using UnityEngine;
    
    
    public partial class MenuSystemBase : uFrame.ECS.EcsSystem {
        
        private IEcsComponentManagerOf<SubMenuComponent> _SubMenuComponentManager;
        
        private IEcsComponentManagerOf<MenuComponent> _MenuComponentManager;
        
        private IEcsComponentManagerOf<LeftHandComponent> _LeftHandComponentManager;
        
        private IEcsComponentManagerOf<RightHandComponent> _RightHandComponentManager;
        
        private IEcsComponentManagerOf<MenuSelectionComponent> _MenuSelectionComponentManager;
        
        private IEcsComponentManagerOf<MenuItemComponent> _MenuItemComponentManager;
        
        private IEcsComponentManagerOf<SubMenuItemComponent> _SubMenuItemComponentManager;
        
        public IEcsComponentManagerOf<SubMenuComponent> SubMenuComponentManager {
            get {
                return _SubMenuComponentManager;
            }
            set {
                _SubMenuComponentManager = value;
            }
        }
        
        public IEcsComponentManagerOf<MenuComponent> MenuComponentManager {
            get {
                return _MenuComponentManager;
            }
            set {
                _MenuComponentManager = value;
            }
        }
        
        public IEcsComponentManagerOf<LeftHandComponent> LeftHandComponentManager {
            get {
                return _LeftHandComponentManager;
            }
            set {
                _LeftHandComponentManager = value;
            }
        }
        
        public IEcsComponentManagerOf<RightHandComponent> RightHandComponentManager {
            get {
                return _RightHandComponentManager;
            }
            set {
                _RightHandComponentManager = value;
            }
        }
        
        public IEcsComponentManagerOf<MenuSelectionComponent> MenuSelectionComponentManager {
            get {
                return _MenuSelectionComponentManager;
            }
            set {
                _MenuSelectionComponentManager = value;
            }
        }
        
        public IEcsComponentManagerOf<MenuItemComponent> MenuItemComponentManager {
            get {
                return _MenuItemComponentManager;
            }
            set {
                _MenuItemComponentManager = value;
            }
        }
        
        public IEcsComponentManagerOf<SubMenuItemComponent> SubMenuItemComponentManager {
            get {
                return _SubMenuItemComponentManager;
            }
            set {
                _SubMenuItemComponentManager = value;
            }
        }
        
        public override void Setup() {
            base.Setup();
            SubMenuComponentManager = ComponentSystem.RegisterComponent<SubMenuComponent>(6);
            MenuComponentManager = ComponentSystem.RegisterComponent<MenuComponent>(4);
            LeftHandComponentManager = ComponentSystem.RegisterComponent<LeftHandComponent>(1);
            RightHandComponentManager = ComponentSystem.RegisterComponent<RightHandComponent>(2);
            MenuSelectionComponentManager = ComponentSystem.RegisterComponent<MenuSelectionComponent>(3);
            MenuItemComponentManager = ComponentSystem.RegisterComponent<MenuItemComponent>(5);
            SubMenuItemComponentManager = ComponentSystem.RegisterComponent<SubMenuItemComponent>(7);
        }
    }
    
    [uFrame.Attributes.uFrameIdentifier("d87d5a1e-6d13-4cb6-8529-2022ab158309")]
    public partial class MenuSystem : MenuSystemBase {
        
        private static MenuSystem _Instance;
        
        public MenuSystem() {
            Instance = this;
        }
        
        public static MenuSystem Instance {
            get {
                return _Instance;
            }
            set {
                _Instance = value;
            }
        }
    }
}
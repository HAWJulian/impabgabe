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
    
    
    #region 
static
    public class abgabewsmoduleExtensions {
        
        #region 
static
        public uFrame.ECS.IEcsComponentManagerOf<MovableObject> MovableObjectManager(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<MovableObject>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.IEcsComponentManagerOf<SubMenuItemComponent> SubMenuItemComponentManager(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<SubMenuItemComponent>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.IEcsComponentManagerOf<MenuComponent> MenuComponentManager(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<MenuComponent>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.IEcsComponentManagerOf<RightHandComponent> RightHandComponentManager(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<RightHandComponent>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.IEcsComponentManagerOf<LeftHandComponent> LeftHandComponentManager(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<LeftHandComponent>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.IEcsComponentManagerOf<SubMenuComponent> SubMenuComponentManager(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<SubMenuComponent>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.IEcsComponentManagerOf<MenuItemComponent> MenuItemComponentManager(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<MenuItemComponent>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.IEcsComponentManagerOf<MenuSelectionComponent> MenuSelectionComponentManager(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<MenuSelectionComponent>();
        }
        #endregion
        
        #region 
static
        public uFrame.ECS.IEcsComponentManagerOf<NewGroupNode> NewGroupNodeManager(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<NewGroupNode>();
        }
        #endregion
        
        #region 
static
        public List<MovableObject> MovableObjectComponents(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<MovableObject>().Components;
        }
        #endregion
        
        #region 
static
        public List<SubMenuItemComponent> SubMenuItemComponentComponents(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<SubMenuItemComponent>().Components;
        }
        #endregion
        
        #region 
static
        public List<MenuComponent> MenuComponentComponents(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<MenuComponent>().Components;
        }
        #endregion
        
        #region 
static
        public List<RightHandComponent> RightHandComponentComponents(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<RightHandComponent>().Components;
        }
        #endregion
        
        #region 
static
        public List<LeftHandComponent> LeftHandComponentComponents(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<LeftHandComponent>().Components;
        }
        #endregion
        
        #region 
static
        public List<SubMenuComponent> SubMenuComponentComponents(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<SubMenuComponent>().Components;
        }
        #endregion
        
        #region 
static
        public List<MenuItemComponent> MenuItemComponentComponents(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<MenuItemComponent>().Components;
        }
        #endregion
        
        #region 
static
        public List<MenuSelectionComponent> MenuSelectionComponentComponents(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<MenuSelectionComponent>().Components;
        }
        #endregion
        
        #region 
static
        public List<NewGroupNode> NewGroupNodeComponents(this uFrame.ECS.IEcsSystem system) {
            return system.ComponentSystem.RegisterComponent<NewGroupNode>().Components;
        }
        #endregion
    }
    #endregion
}

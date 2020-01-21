﻿#pragma checksum "C:\Users\s-yangju\source\repos\Macro-Keyboard\SettingsStoragePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "627728054CCEB1429F2334EED70AC3CF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Macro_Keyboard
{
    partial class SettingsStoragePage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class SettingsStoragePage_obj2_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISettingsStoragePage_Bindings
        {
            private global::Macro_Keyboard.SavedSettingsItem dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj2;
            private global::Windows.UI.Xaml.Controls.TextBlock obj3;
            private global::Windows.UI.Xaml.Controls.TextBlock obj4;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj3TextDisabled = false;
            private static bool isobj4TextDisabled = false;

            public SettingsStoragePage_obj2_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 15 && columnNumber == 42)
                {
                    isobj3TextDisabled = true;
                }
                else if (lineNumber == 16 && columnNumber == 42)
                {
                    isobj4TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // SettingsStoragePage.xaml line 14
                        this.obj2 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.StackPanel)target);
                        break;
                    case 3: // SettingsStoragePage.xaml line 15
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 4: // SettingsStoragePage.xaml line 16
                        this.obj4 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj2.Target as global::Windows.UI.Xaml.Controls.StackPanel).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::Macro_Keyboard.SavedSettingsItem) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // ISettingsStoragePage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Macro_Keyboard.SavedSettingsItem)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Macro_Keyboard.SavedSettingsItem obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Title(obj.Title, phase);
                        this.Update_Setting1(obj.Setting1, phase);
                    }
                }
            }
            private void Update_Title(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // SettingsStoragePage.xaml line 15
                    if (!isobj3TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3, obj, null);
                    }
                }
            }
            private void Update_Setting1(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // SettingsStoragePage.xaml line 16
                    if (!isobj4TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj4, obj, null);
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class SettingsStoragePage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ISettingsStoragePage_Bindings
        {
            private global::Macro_Keyboard.SettingsStoragePage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.GridView obj6;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj6ItemsSourceDisabled = false;

            public SettingsStoragePage_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 23 && columnNumber == 19)
                {
                    isobj6ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 6: // SettingsStoragePage.xaml line 23
                        this.obj6 = (global::Windows.UI.Xaml.Controls.GridView)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                throw new global::System.NotImplementedException();
            }

            public void Recycle()
            {
                throw new global::System.NotImplementedException();
            }

            // ISettingsStoragePage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Macro_Keyboard.SettingsStoragePage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Macro_Keyboard.SettingsStoragePage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_SavedSettingsCollection(obj.SavedSettingsCollection, phase);
                    }
                }
            }
            private void Update_SavedSettingsCollection(global::System.Collections.ObjectModel.ObservableCollection<global::Macro_Keyboard.SavedSettingsItem> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // SettingsStoragePage.xaml line 23
                    if (!isobj6ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj6, obj, null);
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 5: // SettingsStoragePage.xaml line 22
                {
                    this.TextinFile = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // SettingsStoragePage.xaml line 23
                {
                    global::Windows.UI.Xaml.Controls.GridView element6 = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    ((global::Windows.UI.Xaml.Controls.GridView)element6).ItemClick += this.GridView_ItemClick;
                }
                break;
            case 7: // SettingsStoragePage.xaml line 31
                {
                    this.ResultTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // SettingsStoragePage.xaml line 32
                {
                    this.CountTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9: // SettingsStoragePage.xaml line 33
                {
                    global::Windows.UI.Xaml.Controls.Button element9 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element9).Click += this.StoredSettingRemove_Click;
                }
                break;
            case 10: // SettingsStoragePage.xaml line 34
                {
                    global::Windows.UI.Xaml.Controls.Button element10 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element10).Click += this.Deserialize_Click;
                }
                break;
            case 11: // SettingsStoragePage.xaml line 35
                {
                    global::Windows.UI.Xaml.Controls.Button element11 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element11).Click += this.DeleteAll_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // SettingsStoragePage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    SettingsStoragePage_obj1_Bindings bindings = new SettingsStoragePage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            case 2: // SettingsStoragePage.xaml line 14
                {                    
                    global::Windows.UI.Xaml.Controls.StackPanel element2 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                    SettingsStoragePage_obj2_Bindings bindings = new SettingsStoragePage_obj2_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element2.DataContext);
                    element2.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element2, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element2, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}


//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public InputComponent input { get { return (InputComponent)GetComponent(InputComponentsLookup.Input); } }
    public bool hasInput { get { return HasComponent(InputComponentsLookup.Input); } }

    public void AddInput(UnityEngine.Vector2 newPosition) {
        var index = InputComponentsLookup.Input;
        var component = (InputComponent)CreateComponent(index, typeof(InputComponent));
        component.position = newPosition;
        AddComponent(index, component);
    }

    public void ReplaceInput(UnityEngine.Vector2 newPosition) {
        var index = InputComponentsLookup.Input;
        var component = (InputComponent)CreateComponent(index, typeof(InputComponent));
        component.position = newPosition;
        ReplaceComponent(index, component);
    }

    public void RemoveInput() {
        RemoveComponent(InputComponentsLookup.Input);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherInput;

    public static Entitas.IMatcher<InputEntity> Input {
        get {
            if (_matcherInput == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.Input);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherInput = matcher;
            }

            return _matcherInput;
        }
    }
}

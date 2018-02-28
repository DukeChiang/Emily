//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public AttempPositionComponent attempPosition { get { return (AttempPositionComponent)GetComponent(GameComponentsLookup.AttempPosition); } }
    public bool hasAttempPosition { get { return HasComponent(GameComponentsLookup.AttempPosition); } }

    public void AddAttempPosition(UnityEngine.Vector2 newValue) {
        var index = GameComponentsLookup.AttempPosition;
        var component = CreateComponent<AttempPositionComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceAttempPosition(UnityEngine.Vector2 newValue) {
        var index = GameComponentsLookup.AttempPosition;
        var component = CreateComponent<AttempPositionComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveAttempPosition() {
        RemoveComponent(GameComponentsLookup.AttempPosition);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherAttempPosition;

    public static Entitas.IMatcher<GameEntity> AttempPosition {
        get {
            if (_matcherAttempPosition == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.AttempPosition);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAttempPosition = matcher;
            }

            return _matcherAttempPosition;
        }
    }
}

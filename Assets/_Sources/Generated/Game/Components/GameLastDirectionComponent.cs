//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public LastDirectionComponent lastDirection { get { return (LastDirectionComponent)GetComponent(GameComponentsLookup.LastDirection); } }
    public bool hasLastDirection { get { return HasComponent(GameComponentsLookup.LastDirection); } }

    public void AddLastDirection(float newAngle) {
        var index = GameComponentsLookup.LastDirection;
        var component = CreateComponent<LastDirectionComponent>(index);
        component.angle = newAngle;
        AddComponent(index, component);
    }

    public void ReplaceLastDirection(float newAngle) {
        var index = GameComponentsLookup.LastDirection;
        var component = CreateComponent<LastDirectionComponent>(index);
        component.angle = newAngle;
        ReplaceComponent(index, component);
    }

    public void RemoveLastDirection() {
        RemoveComponent(GameComponentsLookup.LastDirection);
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

    static Entitas.IMatcher<GameEntity> _matcherLastDirection;

    public static Entitas.IMatcher<GameEntity> LastDirection {
        get {
            if (_matcherLastDirection == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.LastDirection);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherLastDirection = matcher;
            }

            return _matcherLastDirection;
        }
    }
}

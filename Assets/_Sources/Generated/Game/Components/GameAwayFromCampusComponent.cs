//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly AwayFromCampusComponent awayFromCampusComponent = new AwayFromCampusComponent();

    public bool isAwayFromCampus {
        get { return HasComponent(GameComponentsLookup.AwayFromCampus); }
        set {
            if (value != isAwayFromCampus) {
                var index = GameComponentsLookup.AwayFromCampus;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : awayFromCampusComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherAwayFromCampus;

    public static Entitas.IMatcher<GameEntity> AwayFromCampus {
        get {
            if (_matcherAwayFromCampus == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.AwayFromCampus);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherAwayFromCampus = matcher;
            }

            return _matcherAwayFromCampus;
        }
    }
}

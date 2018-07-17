# What?

* `this.BoxCollider()`, `this.Rigidbody2D()`, ... などで参照できる Physics/Physics2D 関連のアクセサを提供します

# Why?

* 毎回アクセサを書くのがシンドイので

# Install

```shell
yarn add "umm/physics_accessor#^1.0.0"
```

# Usage

```csharp
using UnityEngine;
using AccessorUtility;

public class Hoge : MonoBehaviour, IRigidbody2DAccessor {

    public void Start() {
        this.Righdbody2D().AddForce(Vector2.up * 100.0f);
    }

}
```

1. AccessorUtility.IRigidbodyAccessor などを実装します
1. 拡張メソッドとして対応するアクセサが提供されます
    * 提供されているインタフェースとアクセサの対応は以下の通りです

| interface | accessor |
| --- | --- |
| `IPhysicsAccessor` | - |
| `　IRigidbodyAccessor` | `Rigidbody()` |
| `　IColliderAccessor` | - |
| `　　IBoxColliderAccessor` | `BoxCollider()` |
| `　　ICapsuleColliderAccessor` | `CapsuleCollider()` |
| `　　IMeshColliderAccessor` | `MeshCollider()` |
| `　　ISphereColliderAccessor` | `SphereCollider()` |
| `　　ITerrainColliderAccessor` | `TerrainCollider()` |
| `　　IWheelColliderAccessor` | `WheelCollider()` |
| `　IJointAccessor` | - |
| `　　ICharacterJointAccessor` | `CharacterJoint()` |
| `　　IConfigurableJointAccessor` | `ConfigurableJoint()` |
| `　　IFixedJointAccessor` | `FixedJoint()` |
| `　　IHingeJointAccessor` | `HingeJoint()` |
| `　　ISpringJointAccessor` | `SpringJoint()` |
| `IPhysics2DAccessor` | - |
| `　IRigidbody2DAccessor` | `Rigidbody2D()` |
| `　ICollider2DAccessor` | - |
| `　　IBoxCollider2DAccessor` | `BoxCollider2D()` |
| `　　ICircleCollider2DAccessor` | `CircleCollider2D()` |
| `　　IEdgeCollider2DAccessor` | `EdgeCollider2D()` |
| `　　IPolygonCollider2DAccessor` | `PolygonCollider2D()` |
| `　IJoint2DAccessor` | - |
| `　　IDistanceJoint2DAccessor` | `DistanceJoint2D()` |
| `　　IFixedJoint2DAccessor` | `FixedJoint2D()` |
| `　　IFrictionJoint2DAccessor` | `FrictionJoint2D()` |
| `　　IHingeJoint2DAccessor` | `HingeJoint2D()` |
| `　　IRelativeJoint2DAccessor` | `RelativeJoint2D()` |
| `　　ISliderJoint2DAccessor` | `SliderJoint2D()` |
| `　　ISpringJoint2DAccessor` | `SpringJoint2D()` |
| `　　ITargetJoint2DAccessor` | `TargetJoint2D()` |
| `　　IWheelJoint2DAccessor` | `WheelJoint2D()` |

* 階層的に上位に居るインタフェースは下位のインタフェースが提供するアクセサを全て含有します
* `AccessorUtility` を using することで拡張メソッドが提供されます。

# License

Copyright (c) 2017 Tetsuya Mori

Released under the MIT license, see [LICENSE.txt](LICENSE.txt)


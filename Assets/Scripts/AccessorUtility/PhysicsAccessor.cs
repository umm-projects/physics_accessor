using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace AccessorUtility {

    public interface IBoxColliderAccessor {}
    public interface ICapsuleColliderAccessor {}
    public interface IMeshColliderAccessor {}
    public interface ISphereColliderAccessor {}
    public interface ITerrainColliderAccessor {}
    public interface IWheelColliderAccessor {}
    public interface ICharacterJointAccessor {}
    public interface IConfigurableJointAccessor {}
    public interface IFixedJointAccessor {}
    public interface IHingeJointAccessor {}
    public interface ISpringJointAccessor {}
    public interface IBoxCollider2DAccessor {}
    public interface ICircleCollider2DAccessor {}
    public interface IEdgeCollider2DAccessor {}
    public interface IPolygonCollider2DAccessor {}
    public interface IDistanceJoint2DAccessor {}
    public interface IFixedJoint2DAccessor {}
    public interface IFrictionJoint2DAccessor {}
    public interface IHingeJoint2DAccessor {}
    public interface IRelativeJoint2DAccessor {}
    public interface ISliderJoint2DAccessor {}
    public interface ISpringJoint2DAccessor {}
    public interface ITargetJoint2DAccessor {}
    public interface IWheelJoint2DAccessor {}

    public interface IPhysicsAccessor :
        IRigidbodyAccessor,
        IColliderAccessor,
        IJointAccessor {
    }
    public interface IPhysics2DAccessor :
        IRigidbody2DAccessor,
        ICollider2DAccessor,
        IJoint2DAccessor {
    }
    public interface IRigidbodyAccessor {}
    public interface IRigidbody2DAccessor {}
    public interface IColliderAccessor :
        IBoxColliderAccessor,
        ICapsuleColliderAccessor,
        IMeshColliderAccessor,
        ISphereColliderAccessor,
        ITerrainColliderAccessor,
        IWheelColliderAccessor {
    }
    public interface ICollider2DAccessor :
        IBoxCollider2DAccessor,
        ICircleCollider2DAccessor,
        IEdgeCollider2DAccessor,
        IPolygonCollider2DAccessor {
    }
    public interface IJointAccessor :
        ICharacterJointAccessor,
        IConfigurableJointAccessor,
        IFixedJointAccessor,
        IHingeJointAccessor,
        ISpringJointAccessor {
    }
    public interface IJoint2DAccessor :
        IDistanceJoint2DAccessor,
        IFixedJoint2DAccessor,
        IFrictionJoint2DAccessor,
        IHingeJoint2DAccessor,
        IRelativeJoint2DAccessor,
        ISliderJoint2DAccessor,
        ISpringJoint2DAccessor,
        ITargetJoint2DAccessor,
        IWheelJoint2DAccessor{
    }

    [SuppressMessage("ReSharper", "SuspiciousTypeConversion.Global")]
    public static class PhysicsAccessorExtension {

        /// <summary>
        /// Rigidbody の疑似アクセサ
        /// </summary>
        /// <param name="self">IRigidbodyAccessor のインスタンス</param>
        /// <returns>Rigidbody のインスタンス</returns>
        public static Rigidbody Rigidbody(this IRigidbodyAccessor self) {
            return GetAndCacheComponent<Rigidbody>(self as MonoBehaviour);
        }

        /// <summary>
        /// BoxCollider の疑似アクセサ
        /// </summary>
        /// <param name="self">IBoxColliderAccessor のインスタンス</param>
        /// <returns>BoxCollider のインスタンス</returns>
        public static BoxCollider BoxCollider(this IBoxColliderAccessor self) {
            return GetAndCacheComponent<BoxCollider>(self as MonoBehaviour);
        }

        /// <summary>
        /// CapsuleCollider の疑似アクセサ
        /// </summary>
        /// <param name="self">ICapsuleColliderAccessor のインスタンス</param>
        /// <returns>CapsuleCollider のインスタンス</returns>
        public static CapsuleCollider CapsuleCollider(this ICapsuleColliderAccessor self) {
            return GetAndCacheComponent<CapsuleCollider>(self as MonoBehaviour);
        }

        /// <summary>
        /// MeshCollider の疑似アクセサ
        /// </summary>
        /// <param name="self">IMeshColliderAccessor のインスタンス</param>
        /// <returns>MeshCollider のインスタンス</returns>
        public static MeshCollider MeshCollider(this IMeshColliderAccessor self) {
            return GetAndCacheComponent<MeshCollider>(self as MonoBehaviour);
        }

        /// <summary>
        /// SphereCollider の疑似アクセサ
        /// </summary>
        /// <param name="self">ISphereColliderAccessor のインスタンス</param>
        /// <returns>SphereCollider のインスタンス</returns>
        public static SphereCollider SphereCollider(this ISphereColliderAccessor self) {
            return GetAndCacheComponent<SphereCollider>(self as MonoBehaviour);
        }

        /// <summary>
        /// TerrainCollider の疑似アクセサ
        /// </summary>
        /// <param name="self">ITerrainColliderAccessor のインスタンス</param>
        /// <returns>TerrainCollider のインスタンス</returns>
        public static TerrainCollider TerrainCollider(this ITerrainColliderAccessor self) {
            return GetAndCacheComponent<TerrainCollider>(self as MonoBehaviour);
        }

        /// <summary>
        /// WheelCollider の疑似アクセサ
        /// </summary>
        /// <param name="self">IWheelColliderAccessor のインスタンス</param>
        /// <returns>WheelCollider のインスタンス</returns>
        public static WheelCollider WheelCollider(this IWheelColliderAccessor self) {
            return GetAndCacheComponent<WheelCollider>(self as MonoBehaviour);
        }

        /// <summary>
        /// CharacterJoint の疑似アクセサ
        /// </summary>
        /// <param name="self">ICharacterJointAccessor のインスタンス</param>
        /// <returns>CharacterJoint のインスタンス</returns>
        public static CharacterJoint CharacterJoint(this ICharacterJointAccessor self) {
            return GetAndCacheComponent<CharacterJoint>(self as MonoBehaviour);
        }

        /// <summary>
        /// ConfigurableJoint の疑似アクセサ
        /// </summary>
        /// <param name="self">IConfigurableJointAccessor のインスタンス</param>
        /// <returns>ConfigurableJoint のインスタンス</returns>
        public static ConfigurableJoint ConfigurableJoint(this IConfigurableJointAccessor self) {
            return GetAndCacheComponent<ConfigurableJoint>(self as MonoBehaviour);
        }

        /// <summary>
        /// FixedJoint の疑似アクセサ
        /// </summary>
        /// <param name="self">IFixedJointAccessor のインスタンス</param>
        /// <returns>FixedJoint のインスタンス</returns>
        public static FixedJoint FixedJoint(this IFixedJointAccessor self) {
            return GetAndCacheComponent<FixedJoint>(self as MonoBehaviour);
        }

        /// <summary>
        /// HingeJoint の疑似アクセサ
        /// </summary>
        /// <param name="self">IHingeJointAccessor のインスタンス</param>
        /// <returns>HingeJoint のインスタンス</returns>
        public static HingeJoint HingeJoint(this IHingeJointAccessor self) {
            return GetAndCacheComponent<HingeJoint>(self as MonoBehaviour);
        }

        /// <summary>
        /// SpringJoint の疑似アクセサ
        /// </summary>
        /// <param name="self">ISpringJointAccessor のインスタンス</param>
        /// <returns>SpringJoint のインスタンス</returns>
        public static SpringJoint SpringJoint(this ISpringJointAccessor self) {
            return GetAndCacheComponent<SpringJoint>(self as MonoBehaviour);
        }

        /// <summary>
        /// Rigidbody2D の疑似アクセサ
        /// </summary>
        /// <param name="self">IRigidbody2DAccessor のインスタンス</param>
        /// <returns>Rigidbody2D のインスタンス</returns>
        public static Rigidbody2D Rigidbody2D(this IRigidbody2DAccessor self) {
            return GetAndCacheComponent<Rigidbody2D>(self as MonoBehaviour);
        }

        /// <summary>
        /// BoxCollider2D の疑似アクセサ
        /// </summary>
        /// <param name="self">IBoxCollider2DAccessor のインスタンス</param>
        /// <returns>BoxCollider2D のインスタンス</returns>
        public static BoxCollider2D BoxCollider2D(this IBoxCollider2DAccessor self) {
            return GetAndCacheComponent<BoxCollider2D>(self as MonoBehaviour);
        }

        /// <summary>
        /// CircleCollider2D の疑似アクセサ
        /// </summary>
        /// <param name="self">ICircleCollider2DAccessor のインスタンス</param>
        /// <returns>CircleCollider2D のインスタンス</returns>
        public static CircleCollider2D CircleCollider2D(this ICircleCollider2DAccessor self) {
            return GetAndCacheComponent<CircleCollider2D>(self as MonoBehaviour);
        }

        /// <summary>
        /// EdgeCollider2D の疑似アクセサ
        /// </summary>
        /// <param name="self">IEdgeCollider2DAccessor のインスタンス</param>
        /// <returns>EdgeCollider2D のインスタンス</returns>
        public static EdgeCollider2D EdgeCollider2D(this IEdgeCollider2DAccessor self) {
            return GetAndCacheComponent<EdgeCollider2D>(self as MonoBehaviour);
        }

        /// <summary>
        /// PolygonCollider2D の疑似アクセサ
        /// </summary>
        /// <param name="self">IPolygonCollider2DAccessor のインスタンス</param>
        /// <returns>PolygonCollider2D のインスタンス</returns>
        public static PolygonCollider2D PolygonCollider2D(this IPolygonCollider2DAccessor self) {
            return GetAndCacheComponent<PolygonCollider2D>(self as MonoBehaviour);
        }

        /// <summary>
        /// DistanceJoint2D の疑似アクセサ
        /// </summary>
        /// <param name="self">IDistanceJoint2DAccessor のインスタンス</param>
        /// <returns>DistanceJoint2D のインスタンス</returns>
        public static DistanceJoint2D DistanceJoint2D(this IDistanceJoint2DAccessor self) {
            return GetAndCacheComponent<DistanceJoint2D>(self as MonoBehaviour);
        }

        /// <summary>
        /// FixedJoint2D の疑似アクセサ
        /// </summary>
        /// <param name="self">IFixedJoint2DAccessor のインスタンス</param>
        /// <returns>FixedJoint2D のインスタンス</returns>
        public static FixedJoint2D FixedJoint2D(this IFixedJoint2DAccessor self) {
            return GetAndCacheComponent<FixedJoint2D>(self as MonoBehaviour);
        }

        /// <summary>
        /// FrictionJoint2D の疑似アクセサ
        /// </summary>
        /// <param name="self">IFrictionJoint2DAccessor のインスタンス</param>
        /// <returns>FrictionJoint2D のインスタンス</returns>
        public static FrictionJoint2D FrictionJoint2D(this IFrictionJoint2DAccessor self) {
            return GetAndCacheComponent<FrictionJoint2D>(self as MonoBehaviour);
        }

        /// <summary>
        /// HingeJoint2D の疑似アクセサ
        /// </summary>
        /// <param name="self">IHingeJoint2DAccessor のインスタンス</param>
        /// <returns>HingeJoint2D のインスタンス</returns>
        public static HingeJoint2D HingeJoint2D(this IHingeJoint2DAccessor self) {
            return GetAndCacheComponent<HingeJoint2D>(self as MonoBehaviour);
        }

        /// <summary>
        /// RelativeJoint2D の疑似アクセサ
        /// </summary>
        /// <param name="self">IRelativeJoint2DAccessor のインスタンス</param>
        /// <returns>RelativeJoint2D のインスタンス</returns>
        public static RelativeJoint2D RelativeJoint2D(this IRelativeJoint2DAccessor self) {
            return GetAndCacheComponent<RelativeJoint2D>(self as MonoBehaviour);
        }

        /// <summary>
        /// SliderJoint2D の疑似アクセサ
        /// </summary>
        /// <param name="self">ISliderJoint2DAccessor のインスタンス</param>
        /// <returns>SliderJoint2D のインスタンス</returns>
        public static SliderJoint2D SliderJoint2D(this ISliderJoint2DAccessor self) {
            return GetAndCacheComponent<SliderJoint2D>(self as MonoBehaviour);
        }

        /// <summary>
        /// SpringJoint2D の疑似アクセサ
        /// </summary>
        /// <param name="self">ISpringJoint2DAccessor のインスタンス</param>
        /// <returns>SpringJoint2D のインスタンス</returns>
        public static SpringJoint2D SpringJoint2D(this ISpringJoint2DAccessor self) {
            return GetAndCacheComponent<SpringJoint2D>(self as MonoBehaviour);
        }

        /// <summary>
        /// TargetJoint2D の疑似アクセサ
        /// </summary>
        /// <param name="self">ITargetJoint2DAccessor のインスタンス</param>
        /// <returns>TargetJoint2D のインスタンス</returns>
        public static TargetJoint2D TargetJoint2D(this ITargetJoint2DAccessor self) {
            return GetAndCacheComponent<TargetJoint2D>(self as MonoBehaviour);
        }

        /// <summary>
        /// WheelJoint2D の疑似アクセサ
        /// </summary>
        /// <param name="self">IWheelJoint2DAccessor のインスタンス</param>
        /// <returns>WheelJoint2D のインスタンス</returns>
        public static WheelJoint2D WheelJoint2D(this IWheelJoint2DAccessor self) {
            return GetAndCacheComponent<WheelJoint2D>(self as MonoBehaviour);
        }

        /// <summary>
        /// コンポーネントをキャッシュしつつ返す
        /// </summary>
        /// <param name="monoBehaviour">セットする MonoBehaviour のインスタンス</param>
        /// <typeparam name="T">キャッシュ・取得する型</typeparam>
        /// <returns>キャッシュしたインスタンス</returns>
        private static T GetAndCacheComponent<T>(MonoBehaviour monoBehaviour) where T : Component {
            if (monoBehaviour == null) {
                return null;
            }
            // 未セットの場合に、GetComponent した結果をキャッシュさせる
            if (!monoBehaviour.PropertyExists<T>()) {
                T instance = monoBehaviour.gameObject.GetComponent<T>();
                monoBehaviour.PropertySet(instance);
            }
            return monoBehaviour.PropertyGet<T>();
        }

    }

}

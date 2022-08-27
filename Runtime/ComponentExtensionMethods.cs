using UnityEngine;

namespace Kogane
{
    public static partial class GetComponentWithLogExtensionMethods
    {
        //================================================================================
        // GetComponent
        //================================================================================
        /// <summary>
        /// コンポーネントを取得します。取得できなかった場合はログを出力します
        /// </summary>
        public static T GetComponentWithLog<T>( this Component self )
        {
            return self.gameObject.GetComponentWithLog<T>();
        }

        //================================================================================
        // GetComponentInChildren
        //================================================================================
        /// <summary>
        /// 自分自身もしくは子からコンポーネントを取得します。取得できなかった場合はログを出力します
        /// </summary>
        public static T GetComponentInChildrenWithLog<T>( this Component self )
        {
            return self.gameObject.GetComponentInChildrenWithLog<T>();
        }

        /// <summary>
        /// 自分自身もしくは子からコンポーネントを取得します。取得できなかった場合はログを出力します
        /// </summary>
        public static T GetComponentInChildrenWithLog<T>( this Component self, bool includeInactive )
        {
            return self.gameObject.GetComponentInChildrenWithLog<T>( includeInactive );
        }

        //================================================================================
        // GetComponentInChildrenWithoutSelf
        //================================================================================
        /// <summary>
        /// 子からコンポーネントを取得します。取得できなかった場合はログを出力します
        /// </summary>
        public static T GetComponentInChildrenWithoutSelfWithLog<T>( this Component self ) where T : Component
        {
            return self.gameObject.GetComponentInChildrenWithoutSelfWithLog<T>();
        }

        /// <summary>
        /// 子からコンポーネントを取得します。取得できなかった場合はログを出力します
        /// </summary>
        public static T GetComponentInChildrenWithoutSelfWithLog<T>( this Component self, bool includeInactive ) where T : Component
        {
            return self.gameObject.GetComponentInChildrenWithoutSelfWithLog<T>( includeInactive );
        }

        //================================================================================
        // GetComponentInParent
        //================================================================================
        /// <summary>
        /// 自分自身もしくは親からコンポーネントを取得します。取得できなかった場合はログを出力します
        /// </summary>
        public static T GetComponentInParentWithLog<T>( this Component self )
        {
            return self.gameObject.GetComponentInParentWithLog<T>();
        }

        //================================================================================
        // GetComponentInParentWithoutSelf
        //================================================================================
        /// <summary>
        /// 親からコンポーネントを取得します。取得できなかった場合はログを出力します
        /// </summary>
        public static T GetComponentInParentWithoutSelfWithLog<T>( this Component self ) where T : Component
        {
            return self.gameObject.GetComponentInParentWithoutSelfWithLog<T>();
        }

        /// <summary>
        /// 親からコンポーネントを取得します。取得できなかった場合はログを出力します
        /// </summary>
        public static T GetComponentInParentWithoutSelfWithLog<T>( this Component self, bool includeInactive ) where T : Component
        {
            return self.gameObject.GetComponentInParentWithoutSelfWithLog<T>( includeInactive );
        }

        //================================================================================
        // Find
        //================================================================================
        /// <summary>
        /// 指定された名前の子を検索します。取得できなかった場合はログを出力します
        /// </summary>
        public static Transform FindWithLog( this Component self, string name )
        {
            return self.gameObject.FindWithLog( name );
        }

        /// <summary>
        /// 指定された名前の子を検索します。取得できなかった場合はログを出力します
        /// </summary>
        public static GameObject FindGameObjectWithLog( this Component self, string name )
        {
            return self.gameObject.FindGameObjectWithLog( name );
        }

        /// <summary>
        /// 指定された名前の子からコンポーネントを検索します。取得できなかった場合はログを出力します
        /// </summary>
        public static T FindComponentWithLog<T>( this Component self, string name )
        {
            return self.gameObject.FindComponentWithLog<T>( name );
        }

        //================================================================================
        // FindDeep
        //================================================================================
        /// <summary>
        /// 指定された名前の子を検索します。取得できなかった場合はログを出力します
        /// </summary>
        public static GameObject FindDeepWithLog( this Component self, string name )
        {
            return self.gameObject.FindDeepWithLog( name );
        }

        /// <summary>
        /// 指定された名前の子を検索します。取得できなかった場合はログを出力します
        /// </summary>
        public static GameObject FindDeepWithLog( this Component self, string name, bool includeInactive )
        {
            return self.gameObject.FindDeepWithLog( name, includeInactive );
        }
    }
}
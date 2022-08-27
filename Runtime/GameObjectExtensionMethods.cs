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
        public static T GetComponentWithLog<T>( this GameObject self )
        {
            var component = self.GetComponent<T>();

            if ( component == null )
            {
                OnFailureGetComponent?.Invoke( nameof( GetComponentWithLog ), self, typeof( T ) );
            }

            return component;
        }

        //================================================================================
        // GetComponentInChildren
        //================================================================================
        /// <summary>
        /// 自分自身もしくは子からコンポーネントを取得します。取得できなかった場合はログを出力します
        /// </summary>
        public static T GetComponentInChildrenWithLog<T>( this GameObject self )
        {
            return self.GetComponentInChildrenWithLog<T>( false );
        }

        /// <summary>
        /// 自分自身もしくは子からコンポーネントを取得します。取得できなかった場合はログを出力します
        /// </summary>
        public static T GetComponentInChildrenWithLog<T>( this GameObject self, bool includeInactive )
        {
            var component = self.GetComponentInChildren<T>( includeInactive );

            if ( component == null )
            {
                OnFailureGetComponent?.Invoke( nameof( GetComponentInChildrenWithLog ), self, typeof( T ) );
            }

            return component;
        }

        //================================================================================
        // GetComponentInChildrenWithoutSelf
        //================================================================================
        /// <summary>
        /// 子からコンポーネントを取得します。取得できなかった場合はログを出力します
        /// </summary>
        public static T GetComponentInChildrenWithoutSelfWithLog<T>( this GameObject self ) where T : Component
        {
            return self.GetComponentInChildrenWithoutSelfWithLog<T>( false );
        }

        /// <summary>
        /// 子からコンポーネントを取得します。取得できなかった場合はログを出力します
        /// </summary>
        public static T GetComponentInChildrenWithoutSelfWithLog<T>( this GameObject self, bool includeInactive ) where T : Component
        {
            var components = self.GetComponentsInChildren<T>( includeInactive );

            for ( var i = 0; i < components.Length; i++ )
            {
                var component = components[ i ];
                if ( component == null ) continue;
                if ( component.gameObject == self ) continue;
                return component;
            }

            OnFailureGetComponent?.Invoke( nameof( GetComponentInChildrenWithoutSelfWithLog ), self, typeof( T ) );

            return null;
        }

        //================================================================================
        // GetComponentInParent
        //================================================================================
        /// <summary>
        /// 自分自身もしくは親からコンポーネントを取得します。取得できなかった場合はログを出力します
        /// </summary>
        public static T GetComponentInParentWithLog<T>( this GameObject self )
        {
            var component = self.GetComponentInParent<T>();

            if ( component == null )
            {
                OnFailureGetComponent?.Invoke( nameof( GetComponentInParentWithLog ), self, typeof( T ) );
            }

            return component;
        }

        //================================================================================
        // GetComponentInParentWithoutSelf
        //================================================================================
        /// <summary>
        /// 親からコンポーネントを取得します。取得できなかった場合はログを出力します
        /// </summary>
        public static T GetComponentInParentWithoutSelfWithLog<T>( this GameObject self ) where T : Component
        {
            return self.GetComponentInParentWithoutSelfWithLog<T>( false );
        }

        /// <summary>
        /// 親からコンポーネントを取得します。取得できなかった場合はログを出力します
        /// </summary>
        public static T GetComponentInParentWithoutSelfWithLog<T>( this GameObject self, bool includeInactive ) where T : Component
        {
            var components = self.GetComponentsInParent<T>( includeInactive );

            for ( var i = 0; i < components.Length; i++ )
            {
                var component = components[ i ];
                if ( component == null ) continue;
                if ( component.gameObject == self ) continue;
                return component;
            }

            OnFailureGetComponent?.Invoke( nameof( GetComponentInParentWithoutSelfWithLog ), self, typeof( T ) );

            return null;
        }

        //================================================================================
        // Find
        //================================================================================
        /// <summary>
        /// 指定された名前の子を検索します。取得できなかった場合はログを出力します
        /// </summary>
        public static Transform FindWithLog( this GameObject self, string name )
        {
            var transform = self.transform.Find( name );

            if ( transform == null )
            {
                OnFailureFind?.Invoke( nameof( FindWithLog ), self, name );
            }

            return transform;
        }

        /// <summary>
        /// 指定された名前の子を検索します。取得できなかった場合はログを出力します
        /// </summary>
        public static GameObject FindGameObjectWithLog( this GameObject self, string name )
        {
            var transform = self.transform.Find( name );

            if ( transform == null )
            {
                OnFailureFind?.Invoke( nameof( FindGameObjectWithLog ), self, name );
            }

            return transform != null ? transform.gameObject : null;
        }

        /// <summary>
        /// 指定された名前の子からコンポーネントを検索します。取得できなかった場合はログを出力します
        /// </summary>
        public static T FindComponentWithLog<T>( this GameObject self, string name )
        {
            var transform = self.transform.Find( name );

            if ( transform == null )
            {
                OnFailureFind?.Invoke( nameof( FindComponentWithLog ), self, name );
                return default;
            }

            var component = transform.GetComponent<T>();

            if ( component == null )
            {
                OnFailureGetComponent?.Invoke( nameof( FindComponentWithLog ), self, typeof( T ) );
            }

            return component;
        }

        //================================================================================
        // FindDeep
        //================================================================================
        /// <summary>
        /// 指定された名前の子を検索します。取得できなかった場合はログを出力します
        /// </summary>
        public static GameObject FindDeepWithLog( this GameObject self, string name )
        {
            return self.FindDeepWithLog( name, false );
        }

        /// <summary>
        /// 指定された名前の子を検索します。取得できなかった場合はログを出力します
        /// </summary>
        public static GameObject FindDeepWithLog( this GameObject self, string name, bool includeInactive )
        {
            var transforms = self.GetComponentsInChildren<Transform>( includeInactive );

            for ( var i = 0; i < transforms.Length; i++ )
            {
                var transform = transforms[ i ];
                if ( transform.name != name ) continue;
                return transform.gameObject;
            }

            OnFailureFind?.Invoke( nameof( FindDeepWithLog ), self, name );

            return null;
        }
    }
}
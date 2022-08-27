# Kogane Get Component With Log Extension Methods

GetComponent に失敗した時にログ出力できる拡張メソッド

## 使用例

```cs
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Start()
    {
        GetComponentWithLogExtensionMethods.OnFailureGetComponent = ( methodName, gameObject, type ) =>
        {
            Debug.LogError( $@"「{gameObject.name}」から「{methodName}」で「{type.Name}」を取得できませんでした" );
        };

        GetComponentWithLogExtensionMethods.OnFailureFind = ( methodName, gameObject, name ) =>
        {
            Debug.LogError( $@"「{gameObject.name}」から「{methodName}」で「{name}」を取得できませんでした" );
        };

        gameObject.GetComponentWithLog<BoxCollider>();
        gameObject.GetComponentInChildrenWithLog<BoxCollider>();
        gameObject.GetComponentInChildrenWithLog<BoxCollider>( true );
        gameObject.GetComponentInChildrenWithoutSelfWithLog<BoxCollider>();
        gameObject.GetComponentInChildrenWithoutSelfWithLog<BoxCollider>( true );
        gameObject.GetComponentInParentWithLog<BoxCollider>();
        gameObject.GetComponentInParentWithoutSelfWithLog<BoxCollider>();
        gameObject.GetComponentInParentWithoutSelfWithLog<BoxCollider>( true );
        gameObject.FindWithLog( "Child" );
        gameObject.FindGameObjectWithLog( "Child" );
        gameObject.FindComponentWithLog<BoxCollider>( "Child" );
        gameObject.FindDeepWithLog( "Child" );
        gameObject.FindDeepWithLog( "Child", true );

        transform.GetComponentWithLog<BoxCollider>();
        transform.GetComponentInChildrenWithLog<BoxCollider>();
        transform.GetComponentInChildrenWithLog<BoxCollider>( true );
        transform.GetComponentInChildrenWithoutSelfWithLog<BoxCollider>();
        transform.GetComponentInChildrenWithoutSelfWithLog<BoxCollider>( true );
        transform.GetComponentInParentWithLog<BoxCollider>();
        transform.GetComponentInParentWithoutSelfWithLog<BoxCollider>();
        transform.GetComponentInParentWithoutSelfWithLog<BoxCollider>( true );
        transform.FindWithLog( "Child" );
        transform.FindGameObjectWithLog( "Child" );
        transform.FindComponentWithLog<BoxCollider>( "Child" );
        transform.FindDeepWithLog( "Child" );
        transform.FindDeepWithLog( "Child", true );
    }
}
```

![2020-06-28_123925](https://user-images.githubusercontent.com/6134875/85937217-72989500-b93c-11ea-97bd-5e5de723f733.png)

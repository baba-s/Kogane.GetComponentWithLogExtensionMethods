using System;
using UnityEngine;

namespace Kogane
{
	/// <summary>
	/// GetComponent や Find 系の関数でコンポーネントやオブジェクトの取得に失敗した時にログ出力できる拡張メソッドを管理するクラス
	/// </summary>
	public static partial class GetComponentWithLogExtensionMethods
	{
		//================================================================================
		// デリゲート(static)
		//================================================================================
		/// <summary>
		/// コンポーネントの取得に失敗した時に呼び出されます
		/// </summary>
		public static Action<string, GameObject, Type> OnFailureGetComponent { get; set; }

		/// <summary>
		/// オブジェクトの検索に失敗した時に呼び出されます
		/// </summary>
		public static Action<string, GameObject, string> OnFailureFind { get; set; }
	}
}
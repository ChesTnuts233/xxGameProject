using System;
/// <summary>
/// 检测数据绑定
/// </summary>
/// <typeparam name="T"></typeparam>
public struct ModelValue<T>
{
	private T myValue;
	public T MyValue
	{
		get => myValue;
		set
		{
			if (!value.Equals(myValue)) OnValueChange?.Invoke(value);
			myValue = value;

		}
	}
	public event Action<T> OnValueChange;
}
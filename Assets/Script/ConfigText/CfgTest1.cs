using System;
using System.Collections.Generic;
using UnityEngine;

public class CfgTest1 : ConfigBase
{
	public string B;
	public List<int> C;
	public int E;


	public override void Write(int i, string value)
	{
		switch (i)
		{
			case 0:
				ID = PraseInt(value);
				break;
			case 1:
				B = PraseString(value);
				break;
			case 2:
				C = PraseListInt(value);
				break;
			case 3:
				E = PraseInt(value);
				break;
			default:
				UnityEngine.Debug.LogError(GetType().Name + "src i:" + i);
				break;
		}
	}
}

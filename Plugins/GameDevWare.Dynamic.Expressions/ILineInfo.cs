﻿/*
	Copyright (c) 2016 Denis Zykov, GameDevWare.com

	https://www.assetstore.unity3d.com/#!/content/56706
	
	This source code is distributed via Unity Asset Store, 
	to use it in your project you should accept Terms of Service and EULA 
	https://unity3d.com/ru/legal/as_terms
*/

namespace GameDevWare.Dynamic.Expressions
{
	internal interface ILineInfo
	{
		int LineNumber { get; }
		int ColumnNumber { get; }
		int TokenLength { get; }
	}
}

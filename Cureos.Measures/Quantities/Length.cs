// Copyright (c) 2011 Anders Gustafsson, Cureos AB.
// All rights reserved. This software and the accompanying materials
// are made available under the terms of the Eclipse Public License v1.0
// which accompanies this distribution, and is available at
// http://www.eclipse.org/legal/epl-v10.html

using System;

namespace Cureos.Measures
{
	public class Length : IQuantity
	{
		#region CONSTRUCTORS
		
		public Length()
		{
		}
		
		#endregion
		
		#region IMPLEMENTATION IQUANTITY INTERFACE
		
		public Quantity Quantity
		{
			get { return Quantity.Length; }
		}
				
		#endregion
	}
}

﻿// Copyright (c) 2011 Anders Gustafsson, Cureos AB.
// All rights reserved. This software and the accompanying materials
// are made available under the terms of the Eclipse Public License v1.0
// which accompanies this distribution, and is available at
// http://www.eclipse.org/legal/epl-v10.html

namespace Cureos.Measures.Quantities
{
    public struct Area : IQuantity<Area>
    {
        public static readonly Unit<Area> SquareMeter = new Unit<Area>("m²");
        public static readonly Unit<Area> SquareDeciMeter = new Unit<Area>("dm²", Factors.Square(Factors.Deci));
        public static readonly Unit<Area> SquareCentiMeter = new Unit<Area>("cm²", Factors.Square(Factors.Centi));

        private static readonly QuantityDimensions smkDimensions = 2 * Length.Base;

        public QuantityDimensions Dimensions
        {
            get { return smkDimensions; }
        }

        public IUnit<Area> StandardUnit
        {
            get { return SquareMeter; }
        }
    }
}

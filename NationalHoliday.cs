﻿// ******************************************************************************************
//     Assembly:                Budget Enumerations
//     Author:                  Terry D. Eppler
//     Created:                 06-06-2023
// 
//     Last Modified By:        Terry D. Eppler
//     Last Modified On:        06-06-2023
// ******************************************************************************************
// <copyright file="NationalHoliday.cs" company="Terry D. Eppler">
//    This is a Federal Budget, Finance, and Accounting application for the
//    US Environmental Protection Agency (US EPA).
//    Copyright ©  2023  Terry Eppler
// 
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the “Software”),
//    to deal in the Software without restriction,
//    including without limitation the rights to use,
//    copy, modify, merge, publish, distribute, sublicense,
//    and/or sell copies of the Software,
//    and to permit persons to whom the Software is furnished to do so,
//    subject to the following conditions:
// 
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
// 
//    THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
//    INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT.
//    IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
//    DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//    ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
//    DEALINGS IN THE SOFTWARE.
// 
//    You can contact me at:   terryeppler@gmail.com or eppler.terry@epa.gov
// </copyright>
// <summary>
//   NationalHoliday.cs
// </summary>
// ******************************************************************************************

namespace BudgetExecution
{
    using System;
    using System.Threading;

    /// <summary> </summary>
    public enum NationalHoliday
    {
        /// <summary> New Year’s Day, January 1. </summary>
        NewYearsDay,

        /// <summary>
        /// Birthday of Martin Luther King, Jr., the third Monday in January.
        /// </summary>
        MartinLutherKingDay,

        /// <summary> Washington’s Birthday, the third Monday in February. </summary>
        WashingtonsDay,

        /// <summary> Memorial Day, the last Monday in May. </summary>
        MemorialDay,

        /// <summary> Juneteenth National Independence Day, June 19. </summary>
        JuneteenthDay,

        /// <summary> Independence Day, July 4. </summary>
        IndependenceDay,

        /// <summary> Veterans Day, November 11. </summary>
        VeteransDay,

        /// <summary> Labor Day, the first Monday in September. </summary>
        LaborDay,

        /// <summary> Columbus Day, the second Monday in October. </summary>
        ColumbusDay,

        /// <summary> Thanksgiving Day, the fourth Thursday in November. </summary>
        ThanksgivingDay,

        /// <summary> Christmas Day, December 25. </summary>
        ChristmasDay
    }
}
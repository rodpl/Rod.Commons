﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DateRangeUserType.cs" company="Daniel Dabrowski - rod.42n.pl">
//   Copyright (c) Daniel Dabrowski - rod.42n.pl. All rights reserved.
// </copyright>
// <summary>
//   NHibernate database representation of <see cref="DateRange" />
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Four2n.Commons.NHibernate.UserTypes
{
    using System;

    using global::System;

    /// <summary>
    /// NHibernate database representation of <see cref="DateRange"/>
    /// </summary>
    [Serializable]
    public class DateRangeUserType : DateTimeRangeUserType<DateRange>
    {
        /// <summary>
        /// Compare two instances of the class mapped by this type for persistence
        /// "equality", ie. equality of persistent state.
        /// </summary>
        /// <param name="x">The <see cref="object"/> to compare with this instance.</param>
        /// <param name="y">The other object to compare.</param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object x, object y)
        {
            var result = DateRange.Equals(x, y);
            return result;
        }

        /// <summary>
        /// Creates <see cref="IDateTimeRange"/> instance.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <returns>Instance of date range object.</returns>
        protected override DateRange Create(DateTime? startDate, DateTime? endDate)
        {
            return new DateRange(startDate, endDate);
        }

        protected override DateRange CreateInfinite()
        {
            return DateRange.Infinite;
        }
    }
}
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Search.Models
{
    /// <summary> Represents a date and time. </summary>
    internal partial class OperatingHoursTime
    {
        /// <summary> Initializes a new instance of OperatingHoursTime. </summary>
        internal OperatingHoursTime()
        {
        }

        /// <summary> Initializes a new instance of OperatingHoursTime. </summary>
        /// <param name="date"> Represents current calendar date in POI time zone, e.g. "2019-02-07". </param>
        /// <param name="hour"> Hours are in the 24 hour format in the local time of a POI; possible values are 0 - 23. </param>
        /// <param name="minute"> Minutes are in the local time of a POI; possible values are 0 - 59. </param>
        internal OperatingHoursTime(string date, int? hour, int? minute)
        {
            Date = date;
            Hour = hour;
            Minute = minute;
        }

        /// <summary> Represents current calendar date in POI time zone, e.g. "2019-02-07". </summary>
        public string Date { get; }
        /// <summary> Hours are in the 24 hour format in the local time of a POI; possible values are 0 - 23. </summary>
        public int? Hour { get; }
        /// <summary> Minutes are in the local time of a POI; possible values are 0 - 59. </summary>
        public int? Minute { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    internal static partial class OperationalInsightsWorkspaceCapacityReservationLevelExtensions
    {
        public static OperationalInsightsWorkspaceCapacityReservationLevel ToOperationalInsightsWorkspaceCapacityReservationLevel(this int value)
        {
            if (value == 100) return OperationalInsightsWorkspaceCapacityReservationLevel.OneHundred;
            if (value == 200) return OperationalInsightsWorkspaceCapacityReservationLevel.TwoHundred;
            if (value == 300) return OperationalInsightsWorkspaceCapacityReservationLevel.ThreeHundred;
            if (value == 400) return OperationalInsightsWorkspaceCapacityReservationLevel.FourHundred;
            if (value == 500) return OperationalInsightsWorkspaceCapacityReservationLevel.FiveHundred;
            if (value == 1000) return OperationalInsightsWorkspaceCapacityReservationLevel.TenHundred;
            if (value == 2000) return OperationalInsightsWorkspaceCapacityReservationLevel.TwoThousand;
            if (value == 5000) return OperationalInsightsWorkspaceCapacityReservationLevel.FiveThousand;
            if (value == 10000) return OperationalInsightsWorkspaceCapacityReservationLevel.TenThousand;
            if (value == 25000) return OperationalInsightsWorkspaceCapacityReservationLevel.TwentyFiveThousand;
            if (value == 50000) return OperationalInsightsWorkspaceCapacityReservationLevel.FiftyThousand;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown OperationalInsightsWorkspaceCapacityReservationLevel value.");
        }
    }
}

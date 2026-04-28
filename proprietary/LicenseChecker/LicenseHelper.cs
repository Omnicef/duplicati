// proprietary/LicenseChecker/LicenseHelper.cs
// Copyright (c) 2026 Duplicati Inc. All rights reserved.

namespace Duplicati.Proprietary.LicenseChecker;

public static class LicenseHelper
{
    // Stub: always return a synthetic unlimited license
    private static readonly LicenseData _unlimitedLicense = new LicenseData
    {
        ValidFrom    = DateTimeOffset.MinValue,
        ValidTo      = DateTimeOffset.MaxValue,
        GeneratedAt  = DateTimeOffset.UtcNow,
        OrganizationId = "unlimited",
        LicenseId    = "unlimited",
        MaxMachines  = int.MaxValue,
        Features = new Dictionary<string, string>
        {
            { DuplicatiLicenseFeatures.Office365Users,               int.MaxValue.ToString() },
            { DuplicatiLicenseFeatures.Office365Groups,              int.MaxValue.ToString() },
            { DuplicatiLicenseFeatures.Office365Sites,               int.MaxValue.ToString() },
            { DuplicatiLicenseFeatures.GoogleWorkspaceUsers,         int.MaxValue.ToString() },
            { DuplicatiLicenseFeatures.GoogleWorkspaceGroups,        int.MaxValue.ToString() },
            { DuplicatiLicenseFeatures.GoogleWorkspaceSharedDrives,  int.MaxValue.ToString() },
            { DuplicatiLicenseFeatures.GoogleWorkspaceSites,         int.MaxValue.ToString() },
        }
    };

    public static void SetRemoteClientLicenseKey(string? key) { }
    public static void ReloadLicense() { }

    public static LicenseData? LicenseData => _unlimitedLicense;
    public static LicenseData? GetLocalLicenseData()  => _unlimitedLicense;
    public static LicenseData? GetRemoteLicenseData() => _unlimitedLicense;

    public static int AvailableOffice365UserSeats         => int.MaxValue;
    public static int AvailableOffice365GroupSeats        => int.MaxValue;
    public static int AvailableOffice365SiteSeats         => int.MaxValue;
    public static int AvailableGoogleWorkspaceUserSeats   => int.MaxValue;
    public static int AvailableGoogleWorkspaceGroupSeats  => int.MaxValue;
    public static int AvailableGoogleWorkspaceSharedDriveSeats => int.MaxValue;
    public static int AvailableGoogleWorkspaceSiteSeats   => int.MaxValue;

    public static bool IsOffice365Enabled      => true;
    public static bool IsGoogleWorkspaceEnabled => true;
}

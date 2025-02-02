﻿using Bit.Core.Repositories;
using Bit.Core.Services;
using Bit.Core.Settings;
using Microsoft.Extensions.Logging;
using NSubstitute;
using Xunit;

namespace Bit.Core.Test.Services;

public class NotificationHubPushRegistrationServiceTests
{
    private readonly NotificationHubPushRegistrationService _sut;

    private readonly IInstallationDeviceRepository _installationDeviceRepository;
    private readonly IFeatureService _featureService;
    private readonly ILogger<NotificationHubPushRegistrationService> _logger;
    private readonly GlobalSettings _globalSettings;

    public NotificationHubPushRegistrationServiceTests()
    {
        _installationDeviceRepository = Substitute.For<IInstallationDeviceRepository>();
        _featureService = Substitute.For<IFeatureService>();
        _logger = Substitute.For<ILogger<NotificationHubPushRegistrationService>>();
        _globalSettings = new GlobalSettings();

        _sut = new NotificationHubPushRegistrationService(
            _installationDeviceRepository,
            _globalSettings,
            _featureService,
            _logger
        );
    }

    // Remove this test when we add actual tests. It only proves that
    // we've properly constructed the system under test.
    [Fact(Skip = "Needs additional work")]
    public void ServiceExists()
    {
        Assert.NotNull(_sut);
    }
}

﻿using GbfRaidfinder.Common;
using GbfRaidfinder.Interfaces;

namespace GbfRaidfinder.Factorys {
    public class ControllerFactory {
        public ControllerFactory(ISettingsController settingsController, ITweetObserver tweetObserver,
            IRaidsController raidsController, IRaidlistController raidlistController, IBlacklistController blacklistController) {
            GetSettingsController = settingsController;
            GetTweetObserver = tweetObserver;
            GetRaidsController = raidsController;
            GetRaidlistController = raidlistController;
            GetBlacklistController = blacklistController;

            GetSettingsController.Load();
            GetRaidsController.Load();
            GetRaidlistController.Load();
            GetBlacklistController.Load();
        }

        public ISettingsController GetSettingsController { get; }

        public IRaidsController GetRaidsController { get; }

        public IRaidlistController GetRaidlistController { get; }

        public ITweetObserver GetTweetObserver { get; }
        public IBlacklistController GetBlacklistController { get; }

        public ILoginController CreateLoginController => new LoginController(GetSettingsController);
    }
}
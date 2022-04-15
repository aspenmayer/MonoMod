﻿using MonoMod.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoMod.Core.Platforms.Runtimes {
    internal abstract class FxBaseRuntime : FxCoreBaseRuntime {
        public override RuntimeKind Target => RuntimeKind.Framework;

        public static FxBaseRuntime CreateForVersion(Version version) {
            if (version.Major == 4) {
                // FX 4.x
                return new FxCLR4Runtime();
            } else if (version.Major == 2) {
                return new FxCLR2Runtime();
            } else {
                // we don't support CLR 1, so this should never be reached
                throw new PlatformNotSupportedException($"CLR version {version} is not suppoted.");
            }
        }
    }
}